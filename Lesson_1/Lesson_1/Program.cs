using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }

    class Program
    {
        static readonly HttpClient httpClient = new();
        static readonly string url = "https://jsonplaceholder.typicode.com/posts/";
        static readonly string fileName = "result.txt";

        static async Task Main(string[] args)
        {
            Post somethingWrong = new Post { userId = 0, id = 0, title = "Пост не загружен", body = "" };
            var tasks = new Task<Post>[10];

            FileCheck(fileName);

            for (int i = 0; i < 10; i++)
            {
                tasks[i] = GetPostAsync(i + 4);
            }

            Task.WaitAll();

            using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.Default))
            {
                foreach (var task in tasks)
                {
                    string somePost = ConvertPostToString(task.Result ?? somethingWrong);
                    await sw.WriteLineAsync(somePost);
                    Console.WriteLine(somePost);
                }
            }

            Console.WriteLine("Загрузка и запись завершены");
            Console.ReadLine();
        }


        static async Task<Post> GetPostAsync(int id)
        {
            var json = await httpClient.GetStringAsync($"{url}{id}");

            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            var post = JsonSerializer.Deserialize<Post>(json, serializeOptions);
            Console.WriteLine($"Загрузка поста с id={id} завершена");
            return post;
        }

        static void FileCheck(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }
            File.Delete(path);
        }

        static string ConvertPostToString(Post post)
        {
            string result =
                $"{post.userId}\n" +
                $"{post.id}\n" +
                $"{post.title}\n" +
                $"{post.body} \n";

            return result;
        }
    }
}

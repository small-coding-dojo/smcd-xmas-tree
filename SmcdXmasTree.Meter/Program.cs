// See https://aka.ms/new-console-template for more information

Console.WriteLine("Start the magic");
HttpClient var = new HttpClient();

// set timeout of 15 seconds
var.Timeout = new TimeSpan(0, 0, 0, 15);

var res = await var.GetAsync("http://localhost:5202/SmcdXmasTree/5000");

// hint: 10000 kills the server with stack overflow


Console.WriteLine(res.StatusCode);

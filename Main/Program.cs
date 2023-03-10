using Main;

Jar jar = new Jar("test jar", "testing jars");

jar.Add("thought 1");
jar.Add("thought 2");
jar.Add("thought 3");
jar.Add("thought 4");
jar.Add("thought 5");
jar.Add("thought 6");
jar.Add("thought 7");
jar.Add("thought 8");
jar.Add("thought 9");
jar.Add("thought 10");

Console.WriteLine(jar.Pull());
Console.WriteLine(jar.Pull());
Console.WriteLine(jar.Pull());
Console.WriteLine(jar.Pull());
Console.WriteLine(jar.Pull());
Console.WriteLine(jar.Pull());
Console.WriteLine(jar.Pull());
Console.WriteLine(jar.Pull());
Console.WriteLine(jar.Pull());
Console.WriteLine(jar.Pull());

Console.ReadLine();
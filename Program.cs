using System.Text;

var sb = new StringBuilder();
sb.AppendLine("O rato roeu a roupa do Rei de Roma");
sb.AppendLine("No ninho de mafagafa tinham 3 mafagafinhas");
sb.AppendLine("Quem tem medo do lobo mau, lobo mau, lobo mau?");

using var sr = new StringReader(sb.ToString());

do
{
      Console.WriteLine(sr.ReadLine());

} while (sr.Peek() >= 0);

Console.WriteLine("Aperte [ENTER] para finalizar");
Console.ReadKey();
{


}
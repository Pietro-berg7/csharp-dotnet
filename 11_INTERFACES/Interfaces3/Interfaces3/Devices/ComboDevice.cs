namespace Interfaces3.Devices
{
    internal class ComboDevice: Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComvoDevice processing " + document);
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}

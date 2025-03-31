namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] posicoesIniciais = ["1 2 N", "3 3 L"];
            string[] comandosIniciais = ["EMEMEMEMM", "MMDMMDMDDM"];

            #region Movimentos do primeiro robô
            string[] coordenadasAtuais = posicoesIniciais[0].Split(' ');

            Robo.posicaoXRoboUm = Convert.ToInt32(coordenadasAtuais[0]);
            Robo.posicaoYRoboUm = Convert.ToInt32(coordenadasAtuais[1]);
            Robo.direcaoRoboUm = Convert.ToChar(coordenadasAtuais[2]);

            char[] instrucoes = comandosIniciais[0].ToCharArray();

            for (int i = 0; i < instrucoes.Length; i++)
            {
                char instrucaoAtual = instrucoes[i];

                if (instrucaoAtual == 'E')
                    Robo.VirarEsquerdaRoboUm();

                else if (instrucaoAtual == 'D')
                    Robo.VirarDireitaRoboUm();

                else if (instrucaoAtual == 'M')
                    Robo.MoverRoboUm();
            }
            #endregion

            #region Movimentos do segundo robô
            coordenadasAtuais = posicoesIniciais[1].Split(' ');

            Robo.posicaoXRoboDois = Convert.ToInt32(coordenadasAtuais[0]);
            Robo.posicaoYRoboDois = Convert.ToInt32(coordenadasAtuais[1]);
            Robo.direcaoRoboDois = Convert.ToChar(coordenadasAtuais[2]);

            instrucoes = comandosIniciais[1].ToCharArray();

            for (int i = 0; i < instrucoes.Length; i++)
            {
                char instrucaoAtual = instrucoes[i];

                if (instrucaoAtual == 'E')
                    Robo.VirarEsquerdaRoboDois();

                else if (instrucaoAtual == 'D')
                    Robo.VirarDireitaRoboDois();

                else if (instrucaoAtual == 'M')
                    Robo.MoverRoboDois();
            }
            #endregion

            Console.WriteLine(Robo.ObterLocalizacaoRoboUm());
            Console.WriteLine(Robo.ObterLocalizacaoRoboDois());

            Console.ReadLine();
        }
    }
}

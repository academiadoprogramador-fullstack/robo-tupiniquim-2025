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

            int posicaoXRoboUm = Convert.ToInt32(coordenadasAtuais[0]);
            int posicaoYRoboUm = Convert.ToInt32(coordenadasAtuais[1]);
            char direcaoRoboUm = Convert.ToChar(coordenadasAtuais[2]);

            char[] instrucoes = comandosIniciais[0].ToCharArray();

            for (int i = 0; i < instrucoes.Length; i++)
            {
                char instrucaoAtual = instrucoes[i];

                // E - Vira pra esquerda
                if (instrucaoAtual == 'E')
                {
                    if (direcaoRoboUm == 'N')
                        direcaoRoboUm = 'O';

                    else if (direcaoRoboUm == 'O')
                        direcaoRoboUm = 'S';

                    else if (direcaoRoboUm == 'S')
                        direcaoRoboUm = 'L';

                    else if (direcaoRoboUm == 'L')
                        direcaoRoboUm = 'N';
                }

                // D - Vira pra direita
                else if (instrucaoAtual == 'D')
                {
                    if (direcaoRoboUm == 'N')
                        direcaoRoboUm = 'L';

                    else if (direcaoRoboUm == 'L')
                        direcaoRoboUm = 'S';

                    else if (direcaoRoboUm == 'S')
                        direcaoRoboUm = 'O';

                    else if (direcaoRoboUm == 'O')
                        direcaoRoboUm = 'N';
                }

                // M - Move pra frente
                else if (instrucaoAtual == 'M')
                {
                    if (direcaoRoboUm == 'N')
                        posicaoYRoboUm++;

                    else if (direcaoRoboUm == 'S')
                        posicaoYRoboUm--;

                    else if (direcaoRoboUm == 'O')
                        posicaoXRoboUm--;

                    else if (direcaoRoboUm == 'L')
                        posicaoXRoboUm++;
                }
            }
            #endregion

            #region Movimentos do segundo robô
            coordenadasAtuais = posicoesIniciais[1].Split(' ');

            int posicaoXRoboDois = Convert.ToInt32(coordenadasAtuais[0]);
            int posicaoYRoboDois = Convert.ToInt32(coordenadasAtuais[1]);
            char direcaoRoboDois = Convert.ToChar(coordenadasAtuais[2]);

            instrucoes = comandosIniciais[1].ToCharArray();

            for (int i = 0; i < instrucoes.Length; i++)
            {
                char instrucaoAtual = instrucoes[i];

                // E - Vira pra esquerda
                if (instrucaoAtual == 'E')
                {
                    if (direcaoRoboDois == 'N')
                        direcaoRoboDois = 'O';

                    else if (direcaoRoboDois == 'O')
                        direcaoRoboDois = 'S';

                    else if (direcaoRoboDois == 'S')
                        direcaoRoboDois = 'L';

                    else if (direcaoRoboDois == 'L')
                        direcaoRoboDois = 'N';
                }

                // D - Vira pra direita
                else if (instrucaoAtual == 'D')
                {
                    if (direcaoRoboDois == 'N')
                        direcaoRoboDois = 'L';

                    else if (direcaoRoboDois == 'L')
                        direcaoRoboDois = 'S';

                    else if (direcaoRoboDois == 'S')
                        direcaoRoboDois = 'O';

                    else if (direcaoRoboDois == 'O')
                        direcaoRoboDois = 'N';
                }

                // M - Move pra frente
                else if (instrucaoAtual == 'M')
                {
                    if (direcaoRoboDois == 'N')
                        posicaoYRoboDois++;

                    else if (direcaoRoboDois == 'S')
                        posicaoYRoboDois--;

                    else if (direcaoRoboDois == 'O')
                        posicaoXRoboDois--;

                    else if (direcaoRoboDois == 'L')
                        posicaoXRoboDois++;
                }
            }
            #endregion

            Console.WriteLine($"{posicaoXRoboUm} {posicaoYRoboUm} {direcaoRoboUm}");
            Console.WriteLine($"{posicaoXRoboDois} {posicaoYRoboDois} {direcaoRoboDois}");

            Console.ReadLine();
        }
    }
}

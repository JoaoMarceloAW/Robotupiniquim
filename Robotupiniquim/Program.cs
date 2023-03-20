namespace Robotupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] comandos = new string[2];
            string[] localizacoes = new string[2];

            Console.Write("Digite o tamanho da área que o robo ira andar: ");
            string area = Console.ReadLine();

            Console.Write("Digite a localição do robô 01: ");
            localizacoes[0] = Console.ReadLine();

            Console.Write("Digite o comando robo 1: ");
            comandos[0] = Console.ReadLine();

            Console.Write("Digite a localição do robô 02: ");
            localizacoes[1] = Console.ReadLine();

            Console.Write("Digite o comando robo 2: ");
            comandos[1] = Console.ReadLine();

            for (int j = 0; j < comandos.Length; j++)
            {
                string[] inputRobo = localizacoes[j].Split(" ");

                int posicaoX = Convert.ToInt32(inputRobo[0]);
                int posicaoY = Convert.ToInt32(inputRobo[1]);

                char direcao = Convert.ToChar(inputRobo[2]);

                string comando = comandos[j];



                char[] instrucoes = comando.ToCharArray();

                for (int i = 0; i < instrucoes.Length; i++)
                {
                    if (instrucoes[i] == 'M')
                    {
                        if (direcao == 'N')
                            posicaoY = posicaoY + 1;

                        if (direcao == 'O')
                            posicaoX = posicaoX - 1;

                        if (direcao == 'S')
                            posicaoY = posicaoY - 1;

                        if (direcao == 'L')
                            posicaoX = posicaoX + 1;
                    }

                    else if (instrucoes[i] == 'E')
                    {
                        if (direcao == 'N')
                            direcao = 'O';

                        else if (direcao == 'O')
                            direcao = 'S';

                        else if (direcao == 'S')
                            direcao = 'L';

                        else if (direcao == 'L')
                            direcao = 'N';
                    }

                    else if (instrucoes[i] == 'D')
                    {
                        switch (direcao)
                        {
                            case 'N': direcao = 'L'; break;
                            case 'O': direcao = 'N'; break;
                            case 'S': direcao = 'O'; break;
                            case 'L': direcao = 'S'; break;

                            default:
                                break;
                        }
                    }
                }




                Console.WriteLine(posicaoX + " " + posicaoY + " " + direcao);

            }
        }
    }
    
}
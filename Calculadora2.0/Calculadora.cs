namespace Calculadora2._0
{
    public class Calculadora
    {
        public Calculadora(float a, float b)
        {
            A = a; 
            B = b;
        }

        //PROPRIEDADES DA CLASSE
        public float A { get; set; }
        public float B { get; set; }
        public float Visor { get; set; }
        //PROPRIEDADES DA CLASSE


        //METODOS DA CLASSE
        public void Somar()
        {
            Visor = A + B;
        }

        public void Substrair()
        {
            if (A < B)
            {
                var posicao = A;
                A = B;
                B = posicao;
            }
            
            Visor = A - B;
        }

        public bool VerificarParOuImpar()
        {
            try
            {
                for (var i = 0; i <= Visor; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"O numero {i} é par");
                    }
                    else
                    {
                        Console.WriteLine($"O numero {i} é Impar");
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        //METODOS DA CLASSE
    }
}

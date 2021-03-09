// 5 – Elabore um programa para efetuar o cálculo do valor de uma prestação em atraso, utilizando a fórmula:
            // PRESTAÇÃO:=VALOR+(VALOR*(TAXA/100)*TEMPO).
            double valor, taxa, prestacao, dia, hora, tempo;
            Console.WriteLine("Digite o valor da prestação: ");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da taxa: ");
            taxa = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de dias em atraso: ");
            dia = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de horas em atraso: ");
            hora = double.Parse(Console.ReadLine());
            tempo = (dia * 24) + hora;
            prestacao = valor+(valor*(taxa/100)*tempo);
            Console.WriteLine("Você tem a pagar: "+prestacao);
            Console.ReadKey();
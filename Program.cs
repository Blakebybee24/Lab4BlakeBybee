for ( int x =0; x<1000; x++)
    { Console.Write($"{x}: ");
        Random r = new Random();
        string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z" };
        string[] vowels = { "a", "e", "i", "o", "u", "y" };
        string Name = "";
        Name += consonants[r.Next(consonants.Length)].ToUpper();
        Name += vowels[r.Next(vowels.Length)];
        int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
        while (b<6)
        {
            Name += consonants[r.Next(consonants.Length)];
            b++;
            Name += vowels[r.Next(vowels.Length)];
            b++;
        }
            Console.Write($"{Name} ");
    Random mid = new Random();
        string[] consonantsmid = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z" };
        string[] vowelsmid = { "a", "e", "i", "o", "u", "y" };
        string Namemid = "";
        Namemid += consonants[mid.Next(consonants.Length)].ToUpper();
        Namemid += vowels[mid.Next(vowels.Length)];
        int c = 2; //c tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
        while (c<6 )
        {
            Namemid += consonantsmid[mid.Next(consonantsmid.Length)];
            c++;
            Namemid += vowelsmid[mid.Next(vowelsmid.Length)];
            c++;
        }
            Console.Write($"{Namemid} ");
    Random last = new Random();
        string[] consonantlast = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z" };
        string[] vowelslast = { "a", "e", "i", "o", "u", "y" };
        string Namelast = "";
        Namelast += consonants[last.Next(consonants.Length)].ToUpper();
        Namelast += vowels[last.Next(vowels.Length)];
        int d = 2; //d tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
        while (d<6 )
        {
            Namelast += consonants[last.Next(consonants.Length)];
            d++;
            Namelast += vowelslast[last.Next(vowelslast.Length)];
            d++;
        }
            Console.Write( $"{Namelast}: ");
        
       Random jobs1 = new Random();
       string [] jobs = {"Engineer", "Doctor", "scientist", "professional athlete"};
       string jobsNames = "";
        jobsNames = jobs[jobs1.Next(jobs.Length)] ;
        Console.Write ($"{jobsNames}: ");

        Random h = new Random();
        int hint = h.Next(8,100);
        int range = 100;
        double hDouble = h.NextDouble()*range;
        if (hDouble < 7.5) {
            hDouble = hDouble*10;

        }
        Console.WriteLine ($":$/h {hDouble} 00.00");
        


           

    }
    Console.ReadKey();


    
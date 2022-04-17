
    Console.WriteLine("Napiš co jen chceš prosím");
    string txt = Console.ReadLine();

    Console.WriteLine("Ted' prosím napiš znak který chceš abych vyhledal");
    string searchLetter = Console.ReadLine();

    int x = txt.IndexOf(searchLetter);
    int z = 0;
    if(x == -1){
        Console.WriteLine("Nic jsem nenašel :(");
        Console.ReadKey();
    } else{
        string conclution = "";
        while(x != -1){
            z = z + 1;
            conclution = (conclution + (x + z) + ". ");
            txt = txt.Remove(x, 1);
            x = txt.IndexOf(searchLetter);
        }

        Console.WriteLine ("Vyhledávaný znak je v " + conclution + "pozici");
        Console.ReadKey();
    }

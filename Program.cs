string[] kelimeler = {
"kod", "kitap", "bilgisayar", "muhendis",
"yazilimci", "algoritma", "universite", "teknoloji",
"laboratuvar", "gelistirici", "programlama", "veri tabani",
"elektrik-elektronik", "yapay zeka teknolojileri",
"bilgisayar muhendisligi", "yazilim gelistirme uzmani"
};


for (int i = 0; i < kelimeler.Length - 1; i++)
{
    for (int j = i; j < kelimeler.Length - 1; j++)
    {
        if (kelimeler[j].Length > kelimeler[j + 1].Length)
        {
            string temp = kelimeler[j];
            kelimeler[j] = kelimeler[j + 1];
            kelimeler[j + 1] = temp;
        }
    }
}

foreach (string kelime in kelimeler)
{
    Console.Write(kelime + ", ");
}


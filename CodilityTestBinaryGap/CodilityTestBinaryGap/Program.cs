// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


for (int N=1; N< 11; N++)
{
    string strBinary = "";
    strBinary = Convert.ToString(N, 2);

    List<int> listPos = new List<int>();
    List<int> listSub = new List<int>();

    int nMax = 0;
    for (int i = 0; i < strBinary.Length; i++)
    {
        if (strBinary[i].ToString() == "1")
        {
            listPos.Add(i);
        }
    }

    for (int i = 0; i < listPos.Count - 1; i++)
    {
        if (listPos[i + 1] - listPos[i] != 1)
            listSub.Add(listPos[i + 1] - listPos[i]);
    }

    foreach (int pos in listSub)
    {
        if (nMax < pos)
            nMax = pos - 1;
    }

    if (nMax > 0)
        Console.WriteLine(nMax);
    else
        Console.WriteLine(0);
}


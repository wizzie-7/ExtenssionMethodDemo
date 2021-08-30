using System;

namespace ExtenssionMethodDemo
{
    static class ExtenssionString
    {
        public static string UpperCaseFirstLater(this string value)
        {
            if(value.Length>0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return value;
        }
    }
    class ExtenssionMethod
    {

        static void Main()
        {
            //ExtenssionString EXS = new ExtenssionString();
            string es = "the world is yours!!!";
            Console.WriteLine(es.UpperCaseFirstLater());
        }
    }
}

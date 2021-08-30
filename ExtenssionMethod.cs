using System;

namespace ExtenssionMethodDemo
{
    static class ExtenssionString
    {
        public static string UpperCaseFirstLater(this string value)
        {
            if(value.Length>0)
            {
                char[] arr = value.ToCharArray();
                arr[0] = char.ToUpper(arr[0]);
                return new string(arr);
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

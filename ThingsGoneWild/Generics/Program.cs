using System;
using System.Collections.Generic;
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {



            List<string> isimler = new List<string>();
            isimler.Add("Ali can");
            isimler.Add("Ali can");
            string isim = isimler[0];
            isimler.Remove(isim);
            NameList<string> nameList = new NameList<string>();
            nameList.Add("Ali can");
            nameList.Add("Olcay");
            nameList.Add("Mehmet");
            for (int i = 0; i < nameList.Count; i++)
            {
                Console.WriteLine(nameList[i]);
            }
        }

        
    
    }

    class NameList<T> //    Generic Classes
    {
        T[] _array;
        T[] _array2;
        private int _listCount = 0;
        public NameList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {

            _array2 = _array;

            _listCount += 1;
            _array = new T[_listCount];
            for (int i = 0; i < _array2.Length; i++)
            {
                _array[i] = _array2[i];
            }


            _array[_listCount-1] = item;




        }



        //public void Remove(T item)
        //{


        //    for (int i = 0; i < _array.Length; i++)
        //    {

        //        if (_array[i].Equals(item))
        //        {

        //            _array2 = _array;

        //            _array = new T[_listCount];
        //            _listCount  -= 1;
        //            for (int j = 0; j < ; j++)
        //            {

        //                if (_array2[i])
        //                {

        //                }
                    
                    
        //            }
                
        //        }
            
            
            
        //    }
        
        
        //}






        public T this[int index] // indexleme

        {
            get 
            {
                return _array[index]; 
            }
            set 
            {
                _array[index] = value;
            }
        
        }





        public int Count
        {
            get { return _listCount; }
        }


    }

}

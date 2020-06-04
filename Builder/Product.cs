﻿using System.Collections.Generic;

namespace Builder
{
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            //for (int i = 0; i < this._parts.Count; i++)
            //{
            //    str += this._parts[i] + ", ";
            //}

            foreach (var part in _parts)
            {
                str += part + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }
    }
}
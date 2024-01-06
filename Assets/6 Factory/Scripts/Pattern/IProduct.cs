using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Factory
{
    public interface IProduct
    {
        public string ProductName { get; set; }
        public void Initialize();
    }
}

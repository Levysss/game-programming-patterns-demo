using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Factory
{
public abstract class Factory : MonoBehaviour
{
    public abstract IProduct GetProduct(Vector3 position);
    public string GetLog(IProduct product)
    {
        string logMessage = "Factory: created product " + product.ProductName;
        return logMessage;
        
    }
}
}

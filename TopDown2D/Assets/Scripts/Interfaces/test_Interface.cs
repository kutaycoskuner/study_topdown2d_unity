using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test_Interface : MonoBehaviour 
{
    private void Start()
    {
        InterfaceTest interfaceTest = new InterfaceTest();
        
        interfaceTest.TestFunction();
        // TestInterface()
        // TestInterface(interfaceTest);
    }


    private void TestInterface(int_Test interfeys)
    {
        interfeys.TestFunction();
    }

}

public class InterfaceTest : int_Test
{
    public void TestFunction()
    {
        Debug.Log("Interface is working correctly");
    }
}

public interface int_Test
{
    void TestFunction();
}

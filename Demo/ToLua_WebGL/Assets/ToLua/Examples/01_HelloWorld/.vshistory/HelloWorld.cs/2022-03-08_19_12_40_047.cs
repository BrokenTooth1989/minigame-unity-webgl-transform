﻿using UnityEngine;
using LuaInterface;
using System;

public class HelloWorld : MonoBehaviour
{
    IEnumerator Init2()
    {
        yield return AssetBundleLoad.Init();
        Init();
    }

    void Awake()
    {
        LuaState lua = new LuaState();
        lua.Start();
        string hello =
            @"                
                print('hello tolua#')                                  
            ";
        
        lua.DoString(hello, "HelloWorld.cs");
        lua.CheckTop();
        lua.Dispose();
        lua = null;
    }
}

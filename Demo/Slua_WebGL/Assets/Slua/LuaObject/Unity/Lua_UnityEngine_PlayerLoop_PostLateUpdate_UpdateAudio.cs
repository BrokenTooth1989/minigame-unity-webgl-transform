﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_PlayerLoop_PostLateUpdate_UpdateAudio : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.PlayerLoop.PostLateUpdate.UpdateAudio o;
			o=new UnityEngine.PlayerLoop.PostLateUpdate.UpdateAudio();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.PlayerLoop.PostLateUpdate.UpdateAudio");
		createTypeMetatable(l,constructor, typeof(UnityEngine.PlayerLoop.PostLateUpdate.UpdateAudio),typeof(System.ValueType));
	}
}

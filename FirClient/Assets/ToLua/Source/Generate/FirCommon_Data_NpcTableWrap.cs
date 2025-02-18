﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FirCommon_Data_NpcTableWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FirCommon.Data.NpcTable), typeof(System.Object));
		L.RegFunction("Initialize", new LuaCSFunction(Initialize));
		L.RegFunction("GetItems", new LuaCSFunction(GetItems));
		L.RegFunction("AddItem", new LuaCSFunction(AddItem));
		L.RegFunction("GetItemByKey", new LuaCSFunction(GetItemByKey));
		L.RegFunction("New", new LuaCSFunction(_CreateFirCommon_Data_NpcTable));
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.RegVar("name", new LuaCSFunction(get_name), new LuaCSFunction(set_name));
		L.RegVar("items", new LuaCSFunction(get_items), new LuaCSFunction(set_items));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFirCommon_Data_NpcTable(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FirCommon.Data.NpcTable obj = new FirCommon.Data.NpcTable();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FirCommon.Data.NpcTable.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Initialize(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FirCommon.Data.NpcTable obj = (FirCommon.Data.NpcTable)ToLua.CheckObject<FirCommon.Data.NpcTable>(L, 1);
			obj.Initialize();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetItems(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FirCommon.Data.NpcTable obj = (FirCommon.Data.NpcTable)ToLua.CheckObject<FirCommon.Data.NpcTable>(L, 1);
			System.Collections.Generic.List<FirCommon.Data.NpcTableItem> o = obj.GetItems();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddItem(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FirCommon.Data.NpcTable obj = (FirCommon.Data.NpcTable)ToLua.CheckObject<FirCommon.Data.NpcTable>(L, 1);
			FirCommon.Data.NpcTableItem arg0 = (FirCommon.Data.NpcTableItem)ToLua.CheckObject<FirCommon.Data.NpcTableItem>(L, 2);
			obj.AddItem(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetItemByKey(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FirCommon.Data.NpcTable obj = (FirCommon.Data.NpcTable)ToLua.CheckObject<FirCommon.Data.NpcTable>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			FirCommon.Data.NpcTableItem o = obj.GetItemByKey(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FirCommon.Data.NpcTable obj = (FirCommon.Data.NpcTable)o;
			string ret = obj.name;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_items(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FirCommon.Data.NpcTable obj = (FirCommon.Data.NpcTable)o;
			System.Collections.Generic.List<FirCommon.Data.NpcTableItem> ret = obj.items;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index items on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_name(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FirCommon.Data.NpcTable obj = (FirCommon.Data.NpcTable)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.name = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index name on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_items(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FirCommon.Data.NpcTable obj = (FirCommon.Data.NpcTable)o;
			System.Collections.Generic.List<FirCommon.Data.NpcTableItem> arg0 = (System.Collections.Generic.List<FirCommon.Data.NpcTableItem>)ToLua.CheckObject(L, 2, TypeTraits<System.Collections.Generic.List<FirCommon.Data.NpcTableItem>>.type);
			obj.items = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index items on a nil value");
		}
	}
}


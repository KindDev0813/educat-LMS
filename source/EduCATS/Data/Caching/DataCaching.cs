﻿using System;
using EduCATS.Constants;
using MonkeyCache.FileStore;

namespace EduCATS.Data.Caching
{
	public static class DataCaching<T>
	{
		public static void RemoveCache()
		{
			Barrel.Current.EmptyAll();
		}

		public static void Save(string key, T data)
		{
			Barrel.Current.Add(key, data, TimeSpan.FromDays(GlobalConsts.CacheExpirationInDays));
		}

		public static T Get(string key)
		{
			removeExpired();
			return Barrel.Current.Get<T>(key);
		}

		static void removeExpired()
		{
			Barrel.Current.EmptyExpired();
		}
	}
}

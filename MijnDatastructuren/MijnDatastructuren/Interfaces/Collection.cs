﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MijnDatastructuren.Interfaces
{
	public interface Collection<T>
	{
		int Length { get; }
		bool IsEmpty();
		int Size();
		void Add(int index, T item);
		void Push(T item);
		void Pop();
		bool Contains(T item);
		void Remove(T item);
		void RemoveAtIndex(int index);
		void Clear();
		T[] ToArray();
		T Get(int index);
		string ToString();
	}
}

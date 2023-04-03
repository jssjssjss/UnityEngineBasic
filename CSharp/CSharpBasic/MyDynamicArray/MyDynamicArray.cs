﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class MyDynamicArray
    {
        public int Capascity
        {
            get 
            {
                return _data.Length;
            }

        }

        public int Count
        {
            get
            {
                return _count;
            }
        }


        private const int DEFAULT_SIZE = 1;
        private int[] _data = new int[DEFAULT_SIZE];
        private int _count;

        // 삽입 알고리즘
        // 일반적인 경우에 O(1)
        // 공간이 모자랄 경우에 기존 데이터를 전부 순회 하면서 복제해야하기때문에 0(N)
        
        public void Add(int item )
        {
            //사입 공간이 모자랄 경우
            if(_count >= _data.Length)
            {
                // 1. 더 큰 크기의 새로운 배열을 만든다.
                int[] tmp = new int[_data.Length + (int)Math.Ceiling(Math.Log10(_data.Length)) + DEFAULT_SIZE];
                // 현재 가지고 있는 데이터계수를 10의 승수

                // 2. 기존 데이터를 복제한다.
                for (int i = 0; i < _count; i++)
                {
                    tmp[i] = _data[i];  
                }

                // 3. 데이터 배열 참조를 새로운 배열로 바꾼다.
                _data = tmp;

            }

            _data[_count] = item;
            _count++;
        }

        // 탐색 알고리즘
        // 0(N)
        public bool Contains(int item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_data[1]==item)
                    return true;    

            }
            return false;     
        }
        public int FindIndex(int item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_data[1] == item)
                    return i;

            }
            return -1;
        }

        // 삭제 알고리즘
        // 0(N)

        public void RemoveAt(int index)
        {
            // 지우고자 하는 인덱스 뒤부터 끝까지를 한칸씩 앞으로  당김
            for (int i = index; i < _count -1 ; i++)
            {
                _data[i] = _data[i + 1];
            }
            _count--;
            _data[_count] = default(int);
        }
        public bool Remove(int item)
        { 
            int index = FindIndex(item);

            if (index < 0)
                return false;

            RemoveAt(index);
            return true;
          
        }


    }
}


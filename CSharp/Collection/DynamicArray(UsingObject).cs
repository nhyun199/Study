using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class DynamicArray1
    {        
        public object this[int index]
        {
            get
            {
                if (index <0 || index >= _count)
                    throw new IndexOutOfRangeException();

                return _items[index];
            }

            set
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException();

                _items[index] = value;
            }

        }
        // object type으로 만들어보기
        // 동적배열의 초기 크기 = 1

        public int Count => _count; // 실제로 사용하고 있는 _item의 크기 get접근자로..        
        public int Capacivity => _items.Length; // 비어있는 _item의 크기

        private int _count;
        private object[] _items = new object[DefaultSize]; // 배열을 생성, 초기크기를 DefaultSize로 설정함.
        private const int DefaultSize = 1;

        


        public void ADD(object item)    // 삽입
        {
            if (_count >= _items.Length) // 만약, 아이템을 넣을 공간이 부족하다면?
            {
                object[] tmp = new object[_count * 2];  // 기존 배열에 두 배 크기의 새로운 임시 배열을 만든다.

                for (int i = 0; i < _count; i++)    // 생성한 임시 배열에 기존 배열의 요소를 넣는다.
                {
                    tmp[i] = _items[i];
                }
                _items = tmp; // 배열 참조를 새로 만들어진 배열로 바꾼다
            }
            _items[_count] = item; // 가장 마지막에 추가하려는 아이템을 추가한다.
            _count++;
        }
        
        public object Find(Predicate<object> match)
        {
            for (int i = 0; i < _count; i++)
            {
                if (match(_items[i]))
                    return _items[i];
            }
            return default;
        }
        
        public int FindIndex(Predicate<object> match)
        {
            for (int i = 0; i < _count; i++)
            {
                if (match(_items[i]))
                    return i;
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException();

            for (int i = index; i < _count-1; i++)
            {
                _items[i] = _items[i+1];
            }
            _count--;
        }

        public bool Remove(object item)
        {
            int index = FindIndex(x => x == item);

            if (index < 0)
                return false;

            RemoveAt(index);
            return true;

        }
        

        public bool Contains(object item)
        {
            for (int i=0; i < _count; i++)
            {
                if (object.Equals(_items[i], item))
                    return true;
            }

            return false;
        }
        




    }
}

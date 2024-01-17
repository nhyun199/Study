using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Collection
{
    class LinkedListNode<T>
    {
        public T? Value;
        public LinkedListNode<T>? Prev;
        public LinkedListNode<T>? Next;

        public LinkedListNode(T? value)
        {
            Value = value;
        }
    }

    class LinkedList<T> : IEnumerable<T>
        where T : IComparable<T>
        //where T : IEquatable<T>
    {
        public LinkedListNode<T>? First => _first;
        public LinkedListNode<T>? Last => _last;
        public int Count => _count;

        private LinkedListNode<T>? _first, _last, _tmp;  // head, tail 이라고도 함, tmp = 임시 변수
        private int _count;

        /// <summary>
        /// 가장 앞에 삽입
        /// </summary>
        /// <param name="value"></param>
        public void AddFirst(T value)
        {
            _tmp = new LinkedListNode<T>(value);

            // 하나 이상의 노드가 존재한다면 기존의 First가 있다
            if (_first != null)
            {
                _tmp.Next = _first; // 방금 만든 노드의 다음 노드가 기존 first 노드가 되야한다
                _first.Prev = _tmp;
            }

            else
            {
                _last = _tmp;
            }
            _first = _tmp;
            _count++;
        }

        /// <summary>
        /// 가장 뒤에 삽입
        /// </summary>
        /// <param name="value"></param>
        public void AddLast(T value)
        {
            _tmp = new LinkedListNode<T>(value);

            if (_last != null)
            {
                _tmp.Prev = _last;
                _last.Next = _tmp;
            }

            else
            {
                _first = _tmp;
            }
            _last = _tmp;
            _count++;
        }

        /// <summary>
        /// 특정 노드 앞에 삽입
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        public void AddBefore(LinkedListNode<T> node, T value)
        {
            _tmp = new LinkedListNode<T>(value);

            // 기준 노드 이전에 다른 노드가 있다면,
            if (node.Prev != null)
            {
                node.Prev.Next = _tmp;
                _tmp.Prev = node.Prev;
            }
            // 기준 노드 이전에 다른 노드가 없다면, 내가 추가하려는 위치가 first임
            else
            {
                _first = _tmp;
            }
            node.Prev = _tmp;
            _tmp.Next = node;
            _count++;

        }

        /// <summary>
        /// 특정 노드 뒤에 삽입
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        public void AddAfter(LinkedListNode<T> node, T value)
        {
            _tmp = new LinkedListNode<T>(value);

            // 기준 노드 뒤에 다른 노드가 있다면
            if (node.Next != null)
            {
                node.Next.Prev = _tmp;
                _tmp.Next = node.Next;
            }
            // 기준 노드 뒤에 다른 노드가 없다면 내가 추가한 노드가 last 
            else
            {
                _last = _tmp;
            }
            node.Next = _tmp;
            _tmp.Prev = node;
            _count++;
        }

        // 탐색 = first 부터? last 부터?
        /// <summary>
        /// First부터 match 조건에 맞는 노드를 찾을 때까지 Next 탐색
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>        
        public LinkedListNode<T> Find(Predicate<T> match)
        {
            _tmp = _first;

            while (_tmp != null)
            {
                //if(_tmp.Value > 0)
                //    return _tmp;

                if (match(_tmp.Value))
                    return _tmp;

                _tmp = _tmp.Next;
            }
            return null;
        }

        /// <summary>
        /// Last부터 match 조건에 맞는 노드를 찾을 때까지 Prev 탐색
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public LinkedListNode<T> FindLast(Predicate<T> match)
        {
            _tmp = _last;

            while (_tmp != null)
            {
                if (match(_tmp.Value))
                    return _tmp;

                _tmp = _tmp.Prev;
            }
            return null;
        }

        /// <summary>
        /// 노드의 삭제 // 앞 뒤 노드의 존재 유무를 따지고 참조를 변경
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool Remove(LinkedListNode<T> node)
        {
            // 지우려는 노드가 null이라면
            if (node == null)
                return false;

            // 지우려는 노드의 앞에 노드가 존재한다면
            if (node.Prev != null)
            {
                node.Prev.Next = node.Next;
            }
            else
            {
                _first = node.Next;
            }

            // 지우려는 노드의 뒤에 노드가 존재한다면
            if (node.Next != null)
            {
                node.Next.Prev = node.Prev;
            }
            else
            {
                _last = node.Prev;
            }
            _count--;
            return true;
        }

        public bool Remove(T value)
        {
            return Remove(Find(x => x.Equals(value)));
            //return Remove(Find(x => Comparer<T>.Default.Compare(x, value) == 0));

        }

        public bool RemoveLast(T value)
        {
            return Remove(Find(x => x.Equals(value)));
            //return Remove(FindLast(x => Comparer<T>.Default.Compare(x, value) == 0));
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }

        public struct Enumerator : IEnumerator<T>
        {
            public T Current => _node.Value;

            object IEnumerator.Current => _node.Value;

            private LinkedList<T> _data; // 책
            private LinkedListNode<T> _node;  // 현재 노드(페이지)
            private LinkedListNode<T> _error; // default node 책 표지?

            public Enumerator(LinkedList<T> data)
            {
                _data = data;
                _node = _error = new LinkedListNode<T>(default);   // 책 표지 덮은 채로 시작해야 하므로
            }

            public void Dispose()
            {                
            }

            public bool MoveNext()
            {
                if (_node == null)
                    return false;

                _node = _node == _error? _data._first : _node.Next; // 삼항연산자 쓰면 사망?
                return _node != null;   // default Node를 생성                 
            }

            public void Reset()
            {
                _node = _error;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection

{
    public class DynamicArray2<T> : IEnumerable<T>
        where T : IComparable<T>    // where T : => 뒤에 있는 형식 캐스팅(형변환) 암시적 캐스팅이 가능한 경우로 제한
                                    // IComparable 을 상속 받은 것만 사용이 가능하게 함.(인터페이스이므로 객체 생성이 안되므로)
                                    // 외부에서 변경 못하게 제한, IComparable의 멤버를 사용 가능하게 함.
    {
        // 인덱스 탐색
        // O(1) = 자료 갯수가 몇개가 되더라도 연산의 횟수는 동일
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
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

        public int Count => _count;
        public int Capacivity => _items.Length;
        private int _count;
        private T[] _items = new T[DefaultSize];
        private const int DefaultSize = 1;


        // 아이템 삽입
        // 시간복잡도 : O(N)
        // 평상시에는 아이템을 가장 마지막 인덱스에 추가하면 되지만,
        // 최악의 경우는 공간이 모자랄 경우이기 때문에 더 큰 배열을 만들어서
        // 아이템들을 복제해야함 => 자료 개수에 비례한 연산이 필요함
        // 공간복잡도 : O(N) = 2N(상수는 쓰지 않음) : 삽입 알고리즘에서만 필요함
        
        public void ADD(T item)
        {
            if (_count >= _items.Length)
            {
                T[] tmp = new T[_count * 2];
                Array.Copy(_items, tmp, _count);
                _items = tmp;
            }
            _items[_count] = item;
            _count++;
        }

        // Find와 동일함
        public int Findindex(Predicate<T> match)
        {
            for (int i = 0; i < _count; i++)
            {
                if (match(_items[i]))
                    return i;
            }
            return -1;
        }

        // 매치조건 탐색
        // O(N)
        // 최악의 경우, 아이템을 몾 찾았다면 처음부터 끝까지 순회해야 함
        // => 자료 갯수에 비례한 연산이 필요함.
        public T Find(Predicate<T> match)
        {
            for (int i = 0; i < _count; i++)
            {
                if (match(_items[i]))
                    return _items[i];
            }
            return default;
        }

        // 삭제 알고리즘
        // 시간 복잡도 : O(N) = N-1
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException();

            for (int i = index; i < _count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            _count--;
        }
        // 인덱스 삭제
        // 시간 복잡도 : O(N)
        public bool Remove(T item)
        {
            int index = Findindex(x => item.CompareTo(x) == 0);

            if (index < 0)
                return false;

            RemoveAt(index);
            return true;

        }

        public bool Contains(T item)
        {
            for (int i = 0; i < _count; i++)
            {
                // Default 비교연산 (C# 기본제공 비교연산자 쓸 때)
                if (Comparer<T>.Default.Compare(_items[i], item) == 0)  // 주소를 비교함, 이름으로 체크할 수 없음.
                    return true;

                // IComparable 비교연산.. (내가 비교연산내용을 직접 구현해서 쓸때)
                if (item.CompareTo(_items[i]) == 0)
                    return true;
            }
            return false;
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
            // 현재 페이지 내용 읽기
            public T Current => _data[_index];
            
            object IEnumerator.Current => _data[_index];

            private DynamicArray2<T> _data; // 책
            private int _index; // 책의 현재 페이지

            public Enumerator(DynamicArray2<T> data)
            {
                _data = data;
                _index = -1;        // 책 표지를 덮은 상태로 시작
            }

            // 책 읽을 때 필요했던 자원들(리소스)을 메모리에서 해제하는 내용을 구현
            public void Dispose()   // 폐기, 메모리에서 객체를 폐기
            {                
            }

            // 다음 페이지로
            public bool MoveNext()
            {
                // 넘길 수 있는 다음 장이 존재한다면 다음 장으로 넘기고 true 반환
                if (_index < _data._count - 1)
                {
                    _index++;
                    return true;
                }
                return false;
                                
            }

            // 책 덮기
            public void Reset()
            {
                _index = -1;
            }
        }
    }

}

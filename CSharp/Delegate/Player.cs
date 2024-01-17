using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
	public class Player
	{

		public float hp
		{
			get
			{
				return _hp;
			}
			set
			{
				if (_hp == value)
					return;

				_hp = value;
				// ����ȣ��. ������ ��� �Լ� ���ʴ�� ȣ�� �� ��ȯ���� ������ ȣ���� �Լ� ��ȯ��
				onHpChanged(value);
				// ����ȣ��. �ǹ̾��� �Լ�ȣ�⽺���� ���ؼ� �븮�ڿ� ��ϵ� �Լ����� ȣ���ϱ⶧���� 
				// �����ϴ� ���� �����Ͱ� �ִ� ������ �����Ǵ��� ������� �ǵ��� ����� �� �� ����
				onHpChanged.Invoke(value);
				// Null Check ������ : �ش纯���� Null �̸� �׵� ������� �����ʰ� Null ��ȯ
				onHpChanged?.Invoke(value);

				//_ui.Refresh(value);
				//_ui2.Refresh(value);
			}
		}

		private float _hp;

		// �븮�� Ÿ�� ����
		public delegate void OnHpChangedHandler(float value);
		public delegate void OnHpChangedHandlerForInt(int value);
		public delegate void OnHpChangedHandlerForDouble(double value);
		// event ������ 
		// �ش� �븮�ڸ� �ܺο����� �����ϱ� (+=), ��������ϱ� (-=) ������ιۿ� ������� ���ϵ��� ������.
		public event OnHpChangedHandler onHpChanged;
		//public event Action<float> onHpChanged;

		// Action �븮�� : void �� ��ȯ�ϰ� �Ķ���͸� 0 ~ N �� ���� �� �ִ� ������ �Լ��� ������ �� ���
		public event Action action1;
		public event Action<float> action2;
		public event Action<int> action3;
		public event Action<double> action4;
		public event Action<int, string, float> action5;

		// Func �븮�� : T �� ��ȯ�ϰ� �Ķ���͸� 0~N �� ���� �� �ִ� ������ �Լ��� ������ �� ���
		// Generic Ÿ�� ��ô� ���� �����ʿ� ��ȯŸ��, �տ������ʹ� �Ķ����Ÿ��
		public event Func<int, bool> func1;
		public event Func<string, string, bool> func2;

		// Predicate �븮�� : �Ķ���� 1�� �ް�, bool Ÿ���� ��ȯ�ϴ� �Լ� ������ ���
		public event Predicate<int> match1;

		private PlayerUI _ui;
		private PlayerUI2 _ui2;

		public Player(PlayerUI ui, PlayerUI2 ui2)
		{
			_ui = ui;
			_ui2 = ui2;
			func1 += IsBiggerThan4;
			func1.Invoke(5);
		}

		public Player() { }

		bool IsBiggerThan4(int value)
		{
			return value > 4;
		}


	}
}
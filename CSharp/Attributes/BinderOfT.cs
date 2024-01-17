using System.ComponentModel;
using System.Reflection; // Attribute를 사용할 때 이미 사용하고 있음.

namespace Attributes
{
    internal class Binder<T>
    {
        private readonly T _receiver;
        private readonly PropertyDescriptorCollection _sourceProperties;
        private readonly PropertyDescriptorCollection _receiverMappedProperties;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="receiver"> 알림을 받을 객체 (View) </param>
        /// <param name="source"> 알림을 고지하는 데이터 (Model)</param>
        /// <param name="tag"> 소스를 이름 외에도 구분하기 위한 용도</param>
        public Binder(T receiver, INotifyPropertyChanged source, SourceTag tag)
        {
            _receiver = receiver;

            PropertyDescriptorCollection receiverProperties = TypeDescriptor.GetProperties(_receiver); // GoldUI의 프로퍼티 정보 다 읽음
            _sourceProperties = TypeDescriptor.GetProperties(source); // GoldeViewModel 의 프로퍼티 정보 다 읽음

            source.PropertyChanged += OnSourcePropertyChanged; // GoldViewModel의 데이터가 바뀌었을 때, 실행할 내용 구독

            _receiverMappedProperties = new PropertyDescriptorCollection(null);
            // Bind Attribute를 가지고 있으면서, 태그가 일치하는 Receiver 의 Property만을 저장

            foreach (PropertyDescriptor property in receiverProperties)
            {
                BindAttribute attribute = (BindAttribute)property.Attributes[typeof(BindAttribute)];
                if(attribute != null && attribute.Tag == tag) // Bine Attribute가 붙어있으면서 Tag가 동일한 프로퍼티 맵핑
                {
                    _receiverMappedProperties.Add(property);
                }
            }
        }

        /// <summary>
        /// 소스(Sender)의 값이 바뀌었을 때, 매핑된 Receiver가 있다면, Sender의 Property 값으로 Receiver 의 Property 값을 갱신.
        /// </summary>
        /// <param name="sender"> 소스, ViewModel </param>
        /// <param name="args"></param>
        private void OnSourcePropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            PropertyDescriptor property = _receiverMappedProperties[args.PropertyName];
            if (property != null)
            {
                property.SetValue(_receiver, _sourceProperties[args.PropertyName].GetValue(sender));
            }
        }
    }
}

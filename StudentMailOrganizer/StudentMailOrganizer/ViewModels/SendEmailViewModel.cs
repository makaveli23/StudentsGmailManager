﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentMailOrganizer.ViewModels
{
    public class SendEmailViewModel: INotifyPropertyChanged
    {

        string _receiver;
        public string Receiver
        {
            get
            {
                return _receiver;
            }
            set
            {
                _receiver = value;
                RaiseChange("IsValid");
            }
        }

        string _topic;
        public string Topic
        {
            get
            {
                return _topic;
            }
            set
            {
                _topic = value;
                RaiseChange("IsValid");
            }
        }
        string _body;
        public string Body
        {
            get
            {
                return _body;
            }
            set
            {
                _body = value;
                RaiseChange("IsValid");
            }
        }
        public bool IsValid
        {
            get
            {
                return isValid();
            }
        }

        EmailAddressAttribute email;
        RequiredAttribute required;


        public SendEmailViewModel()
        {
            email = new EmailAddressAttribute();
            required = new RequiredAttribute();
        }

        public bool isValid()
        {
            var isEmail = email.IsValid(Receiver);
            var isReqEmail = required.IsValid(email);
            var isReqTopic = required.IsValid(Topic);
            var isReqBody = required.IsValid(Body);

            bool retval = isEmail && isReqEmail && isReqTopic && isReqBody;

            return retval;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void RaiseChange(string propname)
        {
            var x = PropertyChanged;
            if (x != null) x(this, new PropertyChangedEventArgs(propname));
        }
    }
}

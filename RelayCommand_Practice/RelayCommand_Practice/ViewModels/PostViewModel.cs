using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelayCommand_Practice.Models;
using RelayCommand_Practice.Commands;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows;

namespace RelayCommand_Practice.ViewModels
{
    class PostViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //定義一個ICommand型別的參數，他會回傳實作ICommand介面的RelayCommand類別。
        public ICommand UpdateTitleNameCommand { get { return new RelayCommand(UpdateTitleExecute, CanUpdateTitleExecute); } }
        public Post post { get; set; }

        public PostViewModel()
        {
            post = new Post { Content = "", Title = "Unknown" };
        }

        public string PostsTitle
        {
            get { return post.Title; }
            set
            {
                if (post.Title != value)
                {
                    post.Title = value;
                    RaisePropertyChanged("PostsTitle");
                }
                
            }
        }

        // Define PropertyChanged Event handler
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //更新Title，原本放在View那邊的邏輯，藉由繫結的方式來處理按下Button的事件。
        void UpdateTitleExecute()
        {
            MessageBox.Show("UpdateTitleExecute");
            PostsTitle = "SkyMVVM";
        }

        //定義是否可以更新Title
        bool CanUpdateTitleExecute()
        {
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Lab12.Models;
using Xamarin.Forms;

namespace Lab12.ViewModels
{
    public class TaskViewModel : ViewModelBase
    {
        public TaskViewModel()
        {
            ObservableCollection<TaskModel> TaskModels = new ObservableCollection<TaskModel>();
            Save = new Command(() =>
            {
                TaskModels.Add(new TaskModel(Title, Status, Description));
            });

            Get = new Command(() =>
            {
                Tasks = new ObservableCollection<TaskModel>(TaskModels);
            });
        }

        private string title;
        private string description;
        private bool status;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool Status
        {
            get { return status; }
            set
            {
                if (status != value)
                {
                    status = value;
                    OnPropertyChanged();
                }
            }
        }

        private ObservableCollection<TaskModel> tasks;

        public ObservableCollection<TaskModel> Tasks
        {
            get { return tasks; }
            set
            {
                if (tasks != value)
                {
                    tasks = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Save { protected set; get; }
        public ICommand Get { protected set; get; }

    }
}

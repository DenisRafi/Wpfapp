using System;
using System.Collections.Generic;
using System.Windows;
namespace _
{
    public partial class A1 : Window
    {
        public A1()
        {
            InitializeComponent();
            List
            <_1> users = new List
            <_1>();
            users.Add(new _1() { ID = 0, Name = "Denis Rafi", DateOfBirth = new DateTime(2021, 1, 25) });
            users.Add(new _1() { ID = 1, Name = "A 1", DateOfBirth = new DateTime(1, 1, 1) });
            users.Add(new _1() { ID = 2, Name = "A 2", DateOfBirth = new DateTime(2, 2, 3) });
            users.Add(new _1() { ID = 3, Name = "A 3", DateOfBirth = new DateTime(3, 4, 4) });
            users.Add(new _1() { ID = 4, Name = "A 4", DateOfBirth = new DateTime(4, 5, 5) });
            DR.ItemsSource = users;
        }
    }
    public class _1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
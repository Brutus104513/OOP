using MVVM.Models;
using System;
using System.Collections.Generic;

namespace MVVM.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            BlogEntities = new List<BlogEntity>()
            {
                new BlogEntity() {ImagePath = "Lion.png", Article = "Article 1", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas tempus ut mauris id hendrerit. Suspendisse vestibulum feugiat tellus quis ultrices. Pellentesque ultrices lorem mollis tellus accumsan viverra. Morbi magna enim, consectetur in gravida vitae, ultrices ac ipsum. Quisque ut elit diam. Nulla facilisi. Donec elementum in enim eu blandit. Phasellus eleifend ultricies magna, sed tristique massa porttitor ut. Proin mattis velit libero, ac malesuada risus efficitur non. Fusce sed nulla vitae diam interdum eleifend. Quisque justo leo, dictum in sagittis eget, auctor tempus risus. In metus augue, placerat a venenatis vitae, iaculis vitae elit.", Tags = new List<string> {"Tag1", "Tag2", "Tag3", "Tag4"}},
                new BlogEntity() {ImagePath = "Smth.png", Article = "Article 2", Text = "Fusce sollicitudin dolor ut nunc tempor, vel ultrices magna vehicula. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec cursus tortor sed nisi rutrum volutpat. Nam est orci, condimentum in mi vitae, fringilla varius mauris. Aenean rhoncus, dolor nec dictum sagittis, ligula tortor vestibulum ante, ac elementum tellus purus nec dolor. Curabitur tincidunt nulla euismod lorem cursus, eu bibendum quam ultricies. Phasellus ultricies, dolor a vehicula euismod, nisi justo commodo nulla, vitae consectetur lectus metus dictum orci.", Tags = new List<string> {"Tag5", "Tag6", "Tag7", "Tag8"}}
            };
            NewsEntities = new List<NewsEntity>()
            {
                new NewsEntity() {Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vel magna justo. Phasellus malesuada eros vitae facilisis euismod. Nam vel placerat enim. Pellentesque quis finibus lacus. Donec dapibus lacinia orci. Vestibulum efficitur, ligula at cursus iaculis, ex purus elementum mauris, eget elementum lorem tellus vitae urna. Morbi laoreet.", PublishDate = DateTime.Now},
                new NewsEntity() {Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce tincidunt pharetra pulvinar. Donec blandit ut dolor non fermentum. Mauris eu cursus ante. In venenatis, orci ac tristique pellentesque, ante est vestibulum sem, eu venenatis nunc augue eu metus. Curabitur ullamcorper mauris nec congue finibus. Sed vulputate, mi eget. ", PublishDate = DateTime.Now}
            };
        }
    }
}
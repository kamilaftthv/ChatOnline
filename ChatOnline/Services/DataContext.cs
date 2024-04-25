using System.Collections.Generic;
using System;

namespace ChatOnline.Data
{
    public class DataContext
    {
        private List<User> _users;
        private List<User> _chats;

        public DataContext()
        {
            _users = new List<User>();
            _chats = new List<User>();
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void RemoveUser(string userId)
        {
            var userToRemove = _users.FirstOrDefault(u => u.Id == userId);
            if (userToRemove != null)
            {
                _users.Remove(userToRemove);
            }
        }

        public void UpdateUser(User updatedUser)
        {
            var userToUpdate = _users.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (userToUpdate != null)
            {
                userToUpdate.Email = updatedUser.Email;
                userToUpdate.FullName = updatedUser.FullName;
                userToUpdate.Username = updatedUser.Username;
                userToUpdate.Password = updatedUser.Password;
                userToUpdate.Status = updatedUser.Status;
                userToUpdate.Avatar = updatedUser.Avatar;
            }
        }

        public void AddChat(Chat chat)
        {
            _chats.Add(chat);
        }

        public void RemoveChat(string chatId)
        {
            var chatToRemove = _chats.FirstOrDefault(c => c.Id == chatId);
            if (chatToRemove != null)
            {
                _chats.Remove(chatToRemove);
            }
        }

        public void UpdateChat(Chat updatedChat)
        {
            var chatToUpdate = _chats.FirstOrDefault(c => c.Id == updatedChat.Id);
            if (chatToUpdate != null)
            {
                chatToUpdate.Messages = updatedChat.Messages;
                chatToUpdate.Users = updatedChat.Users;
            }
        }
    }
}
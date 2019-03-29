using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CExam.Models
{
        public class Message
    {
        [Key]
        public int MessageId {get;set;}
        public string Content {get;set;}
        public int UserId {get;set;}
    }
    public class Both
    {
        public List<User> AllUsers {get;set;}
        public LoginUser LoginUser {get;set;}
        public User newUser {get;set;}
        public Message newMessage {get;set;}
        public List<Message> AllMessages {get;set;}
    }

}
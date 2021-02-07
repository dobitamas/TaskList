﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.Services.EmailService
{
    public interface IEmailService
    {
        Task SendEmailSync(string ToEmail, string FromName, string Subject, string Message)
    }
}
using SendEmail;

var gmail = new Email("smtp.office365.com", "geovanefitz@outlook.com", "92253711Ge@");
gmail.SendEmail(emailsTo: "almeidafitz@gmail.com" ,subject:"teste",body:"segue Anexo");

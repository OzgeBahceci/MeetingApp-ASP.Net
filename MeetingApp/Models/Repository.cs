namespace MeetingApp.Models
{
    public static class Repository
    {

        public static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Özge", Phone = "0 511 111 11 11", Email = "ozge@hotmail.com", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Huriye", Phone = "0 522 222 22 22", Email = "huriye@hotmail.com", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "Kadir", Phone = "0 533 333 33 33", Email = "kadir@hotmail.com", WillAttend = true });
            _users.Add(new UserInfo() { Id = 4, Name = "Burhan", Phone = "0 544 444 44 44", Email = "burhan@hotmail.com", WillAttend = false });
            _users.Add(new UserInfo() { Id = 5, Name = "Sacit", Phone = "0 555 555 55 55", Email = "sacit@hotmail.com", WillAttend = true });
            _users.Add(new UserInfo() { Id = 6, Name = "Hacer", Phone = "0 566 666 66 66", Email = "hacer@hotmail.com", WillAttend = false });
        }
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreatedUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            // listeye yeni user ekleme
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            //eğer aranılan değer bulunmazsa geriye null değer döndürebilir diye 
            //nullable yap

            //User detayı görüntülenmek istediğinde o id'de bağlı
            // User bilgisi getirilir
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}

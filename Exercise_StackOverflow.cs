using System;

namespace Exercise_2
{
    class Post
    {
        
        private string _title { get; set; }
        private string _description { get; set; }
        private DateTime _datetime { get; set; }
        private int _votes;

        private int post_no = 0;

        public void CreatePost()
        {
            _votes = 0;
            Console.WriteLine("Enter title: ");
            _title = Console.ReadLine();

            Console.WriteLine("Enter description: ");
            _description = Console.ReadLine();

            _datetime = DateTime.Now;
             post_no++;

            Console.WriteLine("Post Created !");

        }

        public int UpVote()
        {
            Console.WriteLine("Vote Added !");
            return _votes++;
        }

        public int DownVote()
        {
            if (_votes == 0)
            {
                Console.WriteLine("Vote Count is already zero !");
                return 0;
            }

            _votes--;
            Console.WriteLine("Vote Deducted !");
            return _votes;
        }

        public void DisplayVotes()
        {
            Console.WriteLine("\nPost {0} :",post_no);
            Console.WriteLine("Title : "+_title);
            Console.WriteLine("Description : "+_description);
            Console.WriteLine("Created on : "+_datetime);
            Console.WriteLine("Total Votes are : " + _votes);

           // return _votes;
        }

    }

    class Exercise_StackOverflow
    {
        static void Main(string[] args)
        {
            /*
            var post = new Post();

            post.CreatePost();

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();

            post.DownVote();

            Console.WriteLine("Total Votes are : "+post.DisplayVotes());
            
            */
            var post = new Post();
            var ans = 'Y';
            do
            {
                Console.WriteLine("1.Create Post \n2.Up Vote \n3.Down Vote \n4.Display Votes\n");
                var ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        post.CreatePost();
                        break;

                    case 2:
                        post.UpVote();
                        break;

                    case 3:
                        post.DownVote();
                        break;

                    case 4:
                        post.DisplayVotes();
                        break;

                    default:
                        Console.WriteLine("Wrong choice entered !");
                        break;

                }
                Console.WriteLine("Continue? (y/n)");
                ans = Convert.ToChar(Console.ReadLine());
            } while (ans == 'y'|| ans=='Y');
        }
    }
}

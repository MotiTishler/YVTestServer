using YVTestServer.DTOs;

namespace YVTestServer.Repos
{
    public class TicketsRepository : ITicketsRepository
    {
        /*
         * In the real world we have to implement a constructor in order to connect the database.
         * But for this test we use demo data, therfore we'll skip the constructor section and define the demo data instead.
         */

        private TimesListDTO[] demoData = {
            new TimesListDTO("8:30", 80, false),
            new TimesListDTO("8:40", 80, false),
            new TimesListDTO("8:50", 65, false),
            new TimesListDTO("9:00", 80, false),
            new TimesListDTO("9:10", 70, false),
            new TimesListDTO("9:20", 60, false),
            new TimesListDTO("9:30", 50, false),
            new TimesListDTO("9:40", 40, false),
            new TimesListDTO("9:50", 30, false),
            new TimesListDTO("10:00", 0, false),
            new TimesListDTO("10:10", 60, true),
            new TimesListDTO("10:20", 50, false),
            new TimesListDTO("10:30", 40, false),
            new TimesListDTO("10:40", 30, false),
            new TimesListDTO("10:50", 20, false),
            new TimesListDTO("11:00", 60, false),
            new TimesListDTO("11:10", 50, false),
            new TimesListDTO("11:20", 40, false),
            new TimesListDTO("11:30", 30, true),
            new TimesListDTO("11:40", 20, false),
            new TimesListDTO("11:50", 10, false),
            new TimesListDTO("12:00", 50, false),
            new TimesListDTO("12:10", 40, false),
            new TimesListDTO("12:20", 30, false),
            new TimesListDTO("12:30", 20, false),
            new TimesListDTO("12:40", 10, false),
            new TimesListDTO("12:50", 0, false),
            new TimesListDTO("13:00", 80, true),
            new TimesListDTO("13:10", 70, false),
            new TimesListDTO("13:20", 60, false),
            new TimesListDTO("13:30", 50, false),
            new TimesListDTO("13:40", 40, false),
            new TimesListDTO("13:50", 30, false),
            new TimesListDTO("14:00", 70, false),
            new TimesListDTO("14:10", 60, true),
            new TimesListDTO("14:20", 50, false),
            new TimesListDTO("14:30", 40, false),
            new TimesListDTO("14:40", 30, false),
            new TimesListDTO("14:50", 20, false),
            new TimesListDTO("15:00", 60, false),
            new TimesListDTO("15:10", 50, false),
            new TimesListDTO("15:20", 40, false),
            new TimesListDTO("15:30", 30, true),
            new TimesListDTO("15:40", 20, false),
            new TimesListDTO("15:50", 10, false),
            new TimesListDTO("16:00", 50, false),
            new TimesListDTO("16:10", 40, false),
            new TimesListDTO("16:20", 30, false),
            new TimesListDTO("16:30", 20, true),
            new TimesListDTO("16:40", 10, false),
            new TimesListDTO("16:50", 0, false),
            new TimesListDTO("17:00", 80, false),
            new TimesListDTO("17:10", 70, false),
            new TimesListDTO("17:20", 60, false),
            new TimesListDTO("17:30", 50, false),
            new TimesListDTO("17:40", 40, false),
            new TimesListDTO("17:50", 30, false)
        };


        public TimesListDTO[] Getlist()
        {
            
            return demoData;

            // Nice to have: build the data dynamically using random numbers
        }

        public OrderTicketsDTO OrderTickets(OrderTicketsDTO dto)
        {
            // 1. Check if the tickets haven't been ordered in the same time by another thread
            bool canOrder = true; //In the real world - await answer from DB
            
            /*
             * In the real world
             * if (canOrder) { update DB over here }
             */

            OrderTicketsDTO ans = new OrderTicketsDTO() { 
                startTime = dto.startTime,
                amount = canOrder ? dto.amount : 0
            };

            return ans;

        }
    }
}

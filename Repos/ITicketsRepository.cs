using YVTestServer.DTOs;

namespace YVTestServer.Repos
{
    public interface ITicketsRepository
    {
        /*
         * In the real world we need to use async functoins in order to deal with the database ect.,
         * therefore we will define the interface by Tasks:
         * 
         * Task<TimesListDTO[]> Getlist();
         * Task<OrderTicketsDTO> OrderTickets(OrderTicketsDTO dto);
         * 
         */
        TimesListDTO[] Getlist();
        OrderTicketsDTO OrderTickets(OrderTicketsDTO dto);
    }
}

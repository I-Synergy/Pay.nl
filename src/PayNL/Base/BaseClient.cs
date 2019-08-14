using PayNL.Services;

namespace PayNL.Base
{
    public abstract class BaseClient
    {
        private protected IClientService ClientService { get; }

        protected BaseClient(IClientService clientService)
        {
            ClientService = clientService;
        }
    }
}

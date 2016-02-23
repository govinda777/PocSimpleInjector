using PocSimpleInjector.Base.Interfaces;

namespace PocSimpleInjector.Base
{
    public class ClienteService : IClienteService
    {
        private readonly IMensagem _mensagem;
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IMensagem mensagem, IClienteRepository clienteRepository)
        {
            _mensagem = mensagem;
            _clienteRepository = clienteRepository;
        }

        public void Adicionar()
        {
            _clienteRepository.Adicionar(new Cliente());
            _mensagem.Enviar();
        }
    }
}
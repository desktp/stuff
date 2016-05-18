namespace Signair_testes
{
    public class ChatHub : Hub
        {
	        public void Send(string name, string message)
		        {
			            Clients.All.broadcastMessage(name, message);
				                
						        }

							        public void LancarPergunta(string pergunta)
								        {
									            Clients.Others.lancarPergunta(pergunta);
										            }

											            public void ResponderPergunta()
												            {
													                Clients.Others.responderPergunta();
															        }
																    }
																    }

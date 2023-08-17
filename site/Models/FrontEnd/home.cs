namespace site.Models
{
    public class home
    {
        public string idioma { get; set; } = string.Empty;
        public string about
        {
            get
            {
                if (idioma == "pt-BR") return "Quem somos";
                if (idioma == "es-AR") return "Quienes somos";
                return "About us";
            }
        }
        public string empresa
        {
            get
            {
                if (idioma == "pt-BR") return "Empresa";
                if (idioma == "es-AR") return "Empresa";
                return "Company";
            }
        }
        public string service
        {
            get
            {
                if (idioma == "pt-BR") return "Serviços";
                if (idioma == "es-AR") return "Servicios";
                return "Service";
            }
        }

        public string serviceDetalhe
        {
            get
            {
                if (idioma == "pt-BR") return "Nossa equipe está preparada para atender grandes os desafios na elaboração de sistemas de Atendimento e Inteligencia Artificial.";
                if (idioma == "es-AR") return "Nuestro equipo está preparado para afrontar grandes retos en el desarrollo de sistemas de Asistencia e Inteligencia Artificial.";
                return "Our team is prepared to meet major challenges in the development of Service and Artificial Intelligence systems.";
            }
        }

        public string microsoft
        {
            get
            {
                if (idioma == "pt-BR") return "Parceiro oficial Microsoft e isso nos capacita a comercializar soluções em Nuvem e desenvolver demandas especializada em ambiente Azure.";
                if (idioma == "es-AR") return "Partner Oficial de Microsoft y esto nos permite comercializar soluciones Cloud y desarrollar demandas especializadas en entorno Azure.";
                return "Official Microsoft Partner and this enables us to market Cloud solutions and develop specialized demands in the Azure environment.";
            }
        }

        public string whatsapp
        {
            get
            {
                if (idioma == "pt-BR") return "Mais do que um WhatsApp Web. Tenha uma plataforma que permite você organizar as mensagens do seu cliente. Enviar e receber imagens e mensagem de voz.";
                if (idioma == "es-AR") return "Más que una Web de WhatsApp. Consigue una plataforma que te permite organizar los mensajes de tus clientes. Envía y recibe imágenes y mensajes de voz.";
                return "More than a WhatsApp Web. Get a platform that allows you to organize your customer's messages. Send and receive pictures and voice messages.";
            }
        }

        public string google
        {
            get
            {
                if (idioma == "pt-BR") return "Com google cloud plataform você tera a disposição todas as ferramentas do Google com total integração e escalabilidade ao alcance das mãos.";
                if (idioma == "es-AR") return "Con Google Cloud Platform tienes todas las herramientas de Google a tu alcance, con total integración y escalabilidad.";
                return "With Google Cloud Platform you will have at your disposal all the Google tools with full integration and scalability at your fingertips.";
            }
        }

        public string vonage
        {
            get
            {
                if (idioma == "pt-BR") return "Trabalhamos com a Vonage pioneira em comunicação de voz pela Internet, envio de SMS e outros serviços de telefonia.";
                if (idioma == "es-AR") return "Trabajamos con Vonage, empresa pionera en comunicación de voz por Internet, envío de SMS y otros servicios de telefonía.";
                return "We work with Vonage, a pioneer in voice communication over the Internet, SMS sending, and other telephony services.";
            }
        }

        public string pricing
        {
            get
            {
                if (idioma == "pt-BR") return "Preço";
                if (idioma == "es-AR") return "Precio";
                return "Pricing";
            }
        }
        public string contact
        {
            get
            {
                if (idioma == "pt-BR") return "Contato";
                if (idioma == "es-AR") return "Contacto";
                return "Pricing";
            }
        }
        public string titulo
        {
            get
            {
                if (idioma == "pt-BR") return "Plataformas de atendimento ao cliente com Inteligência Artificial.";
                if (idioma == "es-AR") return "Plataformas de atención al cliente con Inteligencia Artificial.";
                return "Customer service platforms with Artificial Intelligence.";
            }
        }
        public string subTitulo
        {
            get
            {
                if (idioma == "pt-BR") return "Suportamos WhatsApp, Telefone, SMS e Email.";
                if (idioma == "es-AR") return "Admitimos WhatsApp, Teléfono, SMS y Email.";
                return "We support WhatsApp, Phone, SMS and Email.";
            }
        }
        public string iniciar
        {
            get
            {
                if (idioma == "pt-BR") return "Plataforma de Engajamento de Clientes";
                if (idioma == "es-AR") return "Plataforma de Participación del Cliente";
                return "Customer Engagement Platform";
            }
        }
        public string hello
        {
            get
            {
                if (idioma == "pt-BR") return "Como engajar os cliente em " + DateTime.Now.Year + " ?";
                if (idioma == "es-AR") return "¿Cómo atraer a los clientes en " + DateTime.Now.Year + " ?";
                return "How to engage customers in " + DateTime.Now.Year + " ?";
            }
        }
        public string helloSub
        {
            get
            {
                if (idioma == "pt-BR") return "WhatsApp é o aplicativo de mensagem mais Popular no mundo com 2 Bilhões de usuários em 180 países. fonte:Statista-2022.";
                if (idioma == "es-AR") return "WhatsApp es la aplicación de mensajería más popular del mundo, con 2.000 millones de usuarios en 180 países. fuente:Statista-2022.";
                return "WhatsApp is the world's most popular messaging app with 2 Billion users in 180 countries. source:Statista-2022.";
            }
        }
        public string top1
        {
            get
            {
                if (idioma == "pt-BR") return "Transbordo de atendimento com controle de Fila em Atendimento e Aguardando.";
                if (idioma == "es-AR") return "Attendance overflow with queue control in Attendance and Waiting.";
                return "Desbordamiento de asistencia con control de colas en Asistencia y espera.";
            }
        }
        public string top2
        {
            get
            {
                if (idioma == "pt-BR") return "Inteligência Artificial com Chatbot conversacional, Api Rest para integrar ao seu CRM e outros sistemas.";
                if (idioma == "es-AR") return "Artificial Intelligence with conversational Chatbot, Rest Api to integrate with your CRM and other systems.";
                return "Inteligencia Artificial con Chatbot conversacional, Rest Api para integrar con tu CRM y otros sistemas.";
            }
        }
        public string top3
        {
            get
            {
                if (idioma == "pt-BR") return "Tenha seus clientes como contato e criando engajamentos com disparo de mensagens.";
                if (idioma == "es-AR") return "Consiga que sus clientes se pongan en contacto y creen compromiso con los activadores de mensajería.";
                return "Get your customers as a contact and create engagement with message triggers.";
            }
        }
        public string top4
        {
            get
            {
                if (idioma == "pt-BR") return "Nosso sistema de disparo é muito simples de ser utilizado e você faz tudo pelo site.";
                if (idioma == "es-AR") return "Nuestro sistema de activación es muy simple de usar y usted hace todo a través del site.";
                return "Our triggering system is very simple to use and you do everything through the site.";
            }
        }
        public string oQueFazemos
        {
            get
            {
                if (idioma == "pt-BR") return "Atendemos Bancos, Empresa e Governo";
                if (idioma == "es-AR") return "Que hacemos.";
                return "What we do.";
            }
        }
        public string suboQueFazemos
        {
            get
            {
                if (idioma == "pt-BR") return "Potencializamos a conexão entre o seu negocio e clientes.";
                if (idioma == "es-AR") return "Hacemos llegar tu mensaje a tus clientes.";
                return "We deliver your message to your customers.";
            }
        }
        public string comunicaWhatsApp
        {
            get
            {
                if (idioma == "pt-BR") return "Ouvidoria Governamental. Conectado com ao FalaBr para atender a Lei de Acesso a Informação.";
                if (idioma == "es-AR") return "Comunicación con WhatsApp.";
                return "Communication with WhatsApp.";
            }
        }
        public string subcomunicaWhatsApp
        {
            get
            {
                if (idioma == "pt-BR") return "Envio de Email, WhatsApp, Facebook e SMS. Tudo em uma unica plataforma.";
                if (idioma == "es-AR") return "Con una lista de números de teléfono y un texto, podemos hacer tomas de gran volumen.";
                return "With a list of phone numbers and a text, we are able to make high volume shots.";
            }
        }
        public string name
        {
            get
            {
                if (idioma == "pt-BR") return "Nome";
                if (idioma == "es-AR") return "Nombre";
                return "Name";
            }
        }
        public string pais
        {
            get
            {
                if (idioma == "pt-BR") return "Pais";
                if (idioma == "es-AR") return "País";
                return "Country";
            }
        }
        public string paisSelecione
        {
            get
            {
                if (idioma == "pt-BR") return "Selecione o seu Pais";
                if (idioma == "es-AR") return "Seleccione su país";
                return "Select your Country";
            }
        }
        public string celular
        {
            get
            {
                if (idioma == "pt-BR") return "Número de celular";
                if (idioma == "es-AR") return "Número de celular";
                return "Cell phone number";
            }
        }
        public string assunto
        {
            get
            {
                if (idioma == "pt-BR") return "Assunto";
                if (idioma == "es-AR") return "Asunto";
                return "Subject";
            }
        }

        public string mensagem
        {
            get
            {
                if (idioma == "pt-BR") return "Mensagem";
                if (idioma == "es-AR") return "Mensaje";
                return "Message";
            }
        }

        public string mensagemEnviar
        {
            get
            {
                if (idioma == "pt-BR") return "Enviar Mensagem";
                if (idioma == "es-AR") return "Enviar Mensaje";
                return "Send Message";
            }
        }

        public string loading
        {
            get
            {
                if (idioma == "pt-BR") return "Aguarde estou enviando sua mensagem.";
                if (idioma == "es-AR") return "Por favor, espere y le envío su mensaje.";
                return "Please wait and I am sending your message.";
            }
        }

        public string mensagemRespostaSucesso
        {
            get
            {
                if (idioma == "pt-BR") return "Sua mensagem foi enviada com sucesso. Em breve entraremos em contato.";
                if (idioma == "es-AR") return "Su mensaje se ha enviado correctamente. En breve nos pondremos en contacto con usted.";
                return "Your message was sent successfully. We will contact you soon.";
            }
        }

        public string mensagemRespostaErro
        {
            get
            {
                if (idioma == "pt-BR") return "Desculpe. Tivemos um erro inesperado e acionamos nossa equipe de suporte. Por favor tente novamente mais tarde.";
                if (idioma == "es-AR") return "Lo sentimos. Hemos tenido un error inesperado y hemos activado nuestro equipo de asistencia. Vuelva a intentarlo más tarde.";
                return "Sorry. We had an unexpected error and have activated our support team. Please try again later.";
            }
        }

        public string mensagemContatoWhatsApp
        {
            get
            {
                if (idioma == "pt-BR") return "😍 Olá, *FULANO02*. Recebemos sua mensagem sobre ASSUNTO02 e estamos agilizando o seu atendimento.";
                if (idioma == "es-AR") return "Lo sentimos. Hemos tenido un error inesperado y hemos activado nuestro equipo de asistencia. Vuelva a intentarlo más tarde.";
                return "Sorry. We had an unexpected error and have activated our support team. Please try again later.";
            }
        }
    }
}



# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

Codebase – Uma base de código, muitos lugares pra rodar
A ideia é ter um único repositório de código, mas poder rodar ele em vários ambientes diferentes, tipo produção, teste, ou homologação. Se tiver mais de um repositório pra mesma aplicação, já tá errado.

Dependencies – Deixa claro tudo que tua app precisa
Você tem que declarar todas as bibliotecas e ferramentas que a tua aplicação usa (como NuGet, npm, pip, etc), e não confiar no que já tá instalado no sistema. Assim, qualquer pessoa consegue rodar a aplicação sem surpresas.

Config – Separar o que é configuração do que é código
As coisas que mudam de ambiente (como senhas, URLs, chaves de API) não devem ficar no código. O certo é usar variáveis de ambiente, assim dá pra mudar essas infos sem mexer no código e evitar problemas de segurança.

Backing Services – Trate serviços externos como peças destacáveis
Banco de dados, cache, serviços de email… tudo isso deve ser visto como algo que pode ser trocado ou reconectado fácil. Você só muda a URL ou a variável e já conecta em outro, sem precisar mudar o código.

Build, Release, Run – Três etapas separadas
Você deve dividir a execução da sua app em três momentos:

Build (compila, instala o que precisa),

Release (junta com as configs certas),

Run (roda de verdade).

Assim dá pra testar, versionar e fazer rollback com mais controle.

Processes – Sua app não deve depender da memória
A aplicação deve rodar como processos isolados, sem guardar nada importante na memória local. Se precisar salvar algo (tipo sessão de usuário), isso tem que ir pra um serviço externo, como um banco. Isso facilita escalar e reiniciar sem perder nada.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

Camada de apresentação - Frontend
Camada de aplicação - Application Layer
Camada de Domínio - core
Camada de Persistência - Repository
Camada de Integração - Services 


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

SOA (orientada a serviços) é um estilo mais antigo que já dividia o sistema em partes, mas de um jeito mais pesado. Os serviços eram grandes, meio genéricos, e tudo passava por um barramento central. Muitas vezes os serviços ainda compartilham banco de dados e ficam mais presos uns aos outros.

microserviços é mais moderna e mais solta. Ela divide o sistema em vários pedacinhos menores e bem focados, onde cada serviço faz uma única coisa e pode ser desenvolvido, atualizado e publicado de forma independente.
Cada um tem seu proprio banco de dados.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

Vantagens - segurança, organização, monitoramento, escalabilidade
Desvantagens - custo, complexidade, latência


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

Struct é tipo um pacote leve que copia os dados. Fica na memória rápida e é bom pra coisas simples.

Class é um objeto completo, que passa por referência. Fica na heap e serve pra coisas mais complexas.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

A grande diferença é que o .NET tradicional roda só no Windows, enquanto o .NET Core é multiplataforma Windows, Linux e Mac. Além disso, o .NET Core é mais leve, rápido e ideal pra aplicações modernas.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

REST - Ideal pra integração com web e apps. Usa HTTP com JSON
gRPC - Melhor pra comunicação entre serviços internos. sa HTTP/2 com protobuf binário.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

Numa Single Page Application, o gerenciamento de rotas é feito no frontend, sem recarregar a página. Quando o usuário clica num link, a SPA só troca o conteúdo na tela, usando JavaScript, e atualiza a URL com o history API (tipo /home, /perfil), tudo de forma suave e rápida.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

DevOps é a ideia de juntar desenvolvimento e operações pra entregar software mais rápido e com qualidade. Envolve automação, integração contínua (CI), entrega contínua (CD), testes, deploy e monitoramento, tudo de forma ágil. É mais cultura e processo do que só ferramenta.


10. Explique sobre um método agile.

**Resposta:**

Metodologia agil é um jeito de desenvolver software em partes pequenas, com entregas rápidas e ajustes constantes.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**


CI (Integração Contínua) é quando o código novo é testado e integrado o tempo todo.
CD (Entrega Contínua) é quando esse código é entregue ou implantado de forma automática.

Jenkins
Azure DevOps

12. Qual a diferença entre Docker e Containers.

**Resposta:**

Container é o conceito: uma caixinha leve com tudo que uma app precisa pra rodar.
Docker é a ferramenta mais usada pra criar, gerenciar e rodar esses containers.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

Kubernetes é a plataforma padrão pra orquestrar containers (tipo Docker).
OpenShift é uma versão do Kubernetes com mais recursos prontos, como segurança, CI/CD e painel web.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

API é boa pra integrar sistemas e reaproveitar lógica, mas precisa cuidar de segurança, versão e estabilidade. Se mal feita, vira uma dor de cabeça.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**

Usando autenticação (ex: JWT), HTTPS, validação de dados, rate limit, e controle de acesso por roles. Tudo isso ajuda a evitar ataques e uso indevido.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

Serve pra trocar mensagens entre sistemas de forma assíncrona, sem depender que tudo aconteça na hora. Ajuda na performance, desacoplamento e resiliência da aplicação.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

A estratégia SAGA coordena transações entre microserviços. Ao invés de tudo ser feito de uma vez, ela divide em passos menores, e se algo falhar, executa ações de compensação (tipo desfazer o que já foi feito). Mantém a consistência sem travar tudo.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**

Atuei no desenvolvimento do sistema de Auto de Infração Eletrônico (AIT) na Serttel, focado em tornar o processo de emissão de multas totalmente digital. Participei direto na parte de backend e frontend, garantindo que os dados fossem coletados corretamente dos agentes de trânsito e integrados com os órgãos responsáveis.

Trabalhei com tecnologias como .NET e Angular, implementando regras complexas de validação de infrações, integração com dispositivos móveis, e geração automática de documentos. Um dos maiores desafios foi garantir a confiabilidade dos dados em tempo real, mesmo com falhas de conexão ou uso offline.

O resultado foi um sistema mais ágil, seguro e que reduziu o trabalho manual dos agentes, melhorando a eficiência do processo como um todo.

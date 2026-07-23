# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:** 
Codebase: É uma única base de código que tem controle de versão como por exemplo o Git e que pode gerar vários deploys (para ambiente de teste, homologação e produção)

Config: São as informações como senhas de banco de dados, chaves de API, URLs que ficam fora do código em variáveis de ambiente (por exemplo em um arquivo .env)

Serviços de Apoio: Os serviços auxiliares como banco de dados e filas de mensagens devem ser tratados como recursos externos e são acessados via URLs ou credenciais nas configurações

Dependências: As dependências do projeto devem ser declaradas de forma explícita por exemplo em pacotes do projeto sem confiar no que "ja está instalado" na máquina

Logs: A aplicação só escreve os eventos no console/stdout. Quem cuida de guardar e analisar os logs é a plataforma externa, não o próprio código

Build, release, run: A aplicação deve passar pelo estágio de build, que transforma o código em um executável, a fase de release que junta o build com as configurações atuais e a fase de execução (run) que inicia a aplicação no ambiente de execução


2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
Camada de Negócios (Backend): É o "cérebro" do sistema, que processa as informações, aplica as regras de negócio, valida dados e decide quais informações devem ser salvas ou recuperadas

Camada de Apresentação (Frontend): É a parte visível e interativa com o usuário que tem a função de capturar os comandos do usuário e exibir as respostas do sistema

Camada de Infraestrutura (DevOps): Garante que a aplicação esteja disponível, segura e seja capaz de lidar com um maior número de acessos

Camada de Dados (Persistência): É responsável por gerenciar o armazenamento e a recuperação das informações, então ela se comunica com o banco de dados para poder salvar, atualizar ou ler informações solicitadas pela camada de negócios


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
Sei que a Arquitetura SOA costuma ser serviços maiores que compartilham dados e infraestrutura e é focado na integração corporativa. Já a Arquitetura Microserviços são serviços menores e mais independentes, cada um com seu foco, muitas vezes com banco próprio e comunicação por HTTP ou mensageria 

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
O API Management é uma camada no meio entre quem consome a API e os serviços de verdade. Ela serve para centralizar o controle das APIs, como o acesso, os limites de uso, a documentação e o monitoramento. 
Algumas vantagens: 
- Ter mais controle de acesso, em que eu posso definir quem pode chamar cada API, com chave ou token num lugar só
- Eu posso limitar quantas requisições cada cliente faz, evitando sobrecarga
- A organização que existe pelo fato da documentação, as versões e o monitoramento ficarem centralizados

Algumas desvantagens:
- Uma maior complexidade pelo fato de ter que configurar, manter e entender essa ferramenta, não é apenas "subir a API"
- Se o API Management cair ou ficar lento, pode afetar várias APIs de uma vez
- Muitas soluções são pagas, então o custo pode vir a ser uma desvantagem
- Pode atrapalhar se for mal usado, porque regras demais ou uma configuração errada pode deixar o fluxo mais difícil

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
A Struct é um tipo por valor, então quando você atribui ou passa uma struct, a tendência é copiar o valor. Mudar a cópia não altera a original e costumar ser usada para dados pequenos e mais simples. A Class é um tipo por referência, então quando voce passa uma class para um método, na prática está passando uma referência ao mesmo objeto e se alguem mudar esse objeto, a mudança aparece em outros lugares que usam a mesma referência.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
A principal diferença é que o .NET rodava basicamente no Windows, o .NET Core que é o .NET atual é multiplataforma e roda em Windows, Linux e macOS.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
REST é uma forma comum de API na web em que você expõe os recursos por URLs e usa os métodos HTTP para por exemplo: GET para buscar, POST para criar, PUT para atualizar e DELETE para remover. Além disso, os dados costumam ir em JSON, o que facilita testar no próprio navegador e é simples de entender.
Sobre GRPC eu ainda não tenho muita experiência mas pelo que sei ele tem um formato binário e tem uma implementação mais complexa que o REST.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
No gerenciamento de rotas de uma SPA a troca de tela acontece no frontend sem recarregar a página inteira, então o roteador olha a URL e decide qual componente/tela mostrar.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
DevOps é a prática de aproximar o desenvolvedor de quem opera o sistema. Em vez de o time de desenvolvimento entregar apenas o código e o outro time cuidar sozinho da produção, os dois trabalham juntos no mesmo fluxo. Na prática isso envolve versionar o código no Git, automatizar build e testes (CI), automatizar a publicação (CD) e monitorar o sistema em produção para possíveis erros.

10. Explique sobre um método agile.

**Resposta:**
Um método Agile que é bem comum é o Scrum, em que o trabalho fica organizado num backlog, o time trabalha em sprints (geralmente 1 ou 2 semanas), reuniões diárias (daily) e no final da sprint tem uma review para mostrar o que foi feito nesse tempo. 
A ideia principal é de entregar com uma frequência e adaptar quando necessário.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
O CI é o momento em que o código entra no repositório e a cada push ou pull request, uma ferramenta vai pegar esse código, tenta gerar o build e roda os testes sozinha. Se der erro de compilação ou algum teste falhar, o problema aparece na hora. Já o CD, começa depois que o CI passou e ele prepara a versão pronta e pode publicar automaticamente em um ambiente de homologação ou produção, deixando se ser um processo manual a subida de versão. As ferramentas do dia a dia que eu conheço para isso são GitHub Actions, Azure DevOps e GitLab CI.

12. Qual a diferença entre Docker e Containers.

**Resposta:**
Containers é o conceito de um pacote isolado que roda uma aplicação junto com o que ela precisa para funcionar e o Docker é uma das ferramentas mais usadas para criar, rodar e gerenciar esses Containers.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Kubernetes serve para osquestrar containers, então ele ajuda a subir, manter e escalar várias aplicações em container de forma organizada. Sobre Openshift não tenho muito conhecimento mas sei que é baseado em Kubernetes.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
Uma API ajuda a separar o frontend do backend, permite que web, mobile e outros serviços usem a mesma base, facilita integração entre sistemas e ajuda a evoluir cada parte com mais independência. Também melhora a reutilização, porque a mesma regra de negócio pode atender vários consumidores sem duplicar lógica.

As desvantagens aparecem principalmente na complexidade. Começa a ser necessário versionar contratos, documentar bem os endpoints, cuidar de performance e pensar em autenticação e autorização desde o início. Se a API ficar mal desenhada, qualquer mudança pode quebrar quem já está consumindo. Além disso, o diagnóstico de erro fica mais difícil, porque o problema pode estar no cliente, na rede ou no serviço.

Escolhendo essa abordagem, algumas preocupações importantes são de definir bem as rotas, os status codes, o formato de resposta, garantir HTTPS, usar autenticação, validar tudo que chega do cliente, não expor dados sensíveis e ter logs para saber se a API está funcionando corretamente. Também sei que é importante pensar em versionamento e compatibilidade, para conseguir evoluir sem quebrar os consumidores de uma hora para outra.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Para garantir um nível de segurança satisfatório no uso de APIs o primeiro passo ao meu ver é usar HTTPS para o tráfego entre o cliente e a API, evitando que senhas, tokens e possíveis dados sensíveis sejam lidos. Depois disso, é importante autenticar e autorizar quem está chamando a API, para não deixar endpoint sensível aberto. Também é importante validar tudo que chega do cliente, porque não se deve confiar em dado externo. Além disso, é interessante limitar a quantidade de requisições para dificultar um abuso no uso das APIs e por ultimo utilizar logs e monitoramento.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Uma arquitetura de mensageria serve para os sistemas se comunicarem de forma assíncrona, geralmente por fila, então em vez de um serviço chamar o outro e ficar esperando a resposta na hora, ele publica uma mensagem e segue o fluxo e outro serviço consome essa mensagem depois. Isso é importante porque evite que uma lentidão em um serviço trave tudo imediatamente

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
Não tenho conhecimento sobre a estratégia SAGA.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
Ainda não usei nenhum dos dois na prática. Pelo pouco que entendi, GitOps é uma forma de controlar as atualizações do sistema pelo Git, e o Kubernetes é o ambiente onde as aplicações ficam rodando.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
Durante minha atuação como desenvolvedor full stack na Lawing, eu fiquei responsável por integrar as APIs da Clicksign e da Docusign ao sistema da empresa. A Lawing automatizava contratos e fluxos jurídicos para bancos e escritórios, mas a assinatura digital ainda acontecia fora da plataforma. Os clientes geravam o documento na Lawing e depois precisavam exportar e subir manualmente em outra ferramenta. Isso gerava retrabalho, risco de erro e dificuldade para acompanhar o status do contrato.

Para resolver isso, desenvolvi no back-end em Python a integração com as duas APIs REST. O fluxo lia e enviava os dados em JSON e gravava as informações no banco SQL. O maior desafio foi lidar com as diferenças entre as duas plataformas: a Docusign usava OAuth 2.0 e a Clicksign usava token de API. A documentação também não cobria bem alguns casos mais complexos, como vários signatários em ordem dinâmica e retentativas quando a entrega falhava. Para validar esses cenários, testei as requisições no Postman e conversei com o suporte das duas empresas para entender erros que não estavam bem documentados.

Além do envio dos documentos, implementei webhooks para receber os eventos do ciclo de vida da assinatura. No back-end, tratei essas notificações com validação de segurança e atualizei o status no banco. Assim, ações como visualização, recusa ou assinatura apareciam automaticamente na interface em React. No fim, o processo deixou de depender de exportar e importar arquivo manualmente, o ciclo ficou centralizado na Lawing, com mais controle do status e uma experiência bem mais simples para o cliente.
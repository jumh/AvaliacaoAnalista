# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**  Analise de requisitos, design, codificacao, testes, implementação e manutenção.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:** os microserviços são mais independentes, com cada um podendo ter seu próprio banco de dados, sua própria funcionalidade e de mais fácil escalabilidade. Atuei em um projeto onde o objetivo foi na migração de um sistema monolítico para microsserviços visando resolver problemas de volumetria, resiliência e performance.
O sistema era responsável pela emissão das notas fiscais dos clientes da empresa e tinha um volume de mais de 1 milhão de notas a serem emitidas via API


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:** Serve para gerenciar as API de um sistema e tem como vantagem o monitoramento e analise do trafego de usuarios e uma desvantagem é a complexidade nas configurações. Em 2019, estava atuando em uma empresa do ramo da saude e foi identificado que 90% dos clientes usavam o app para fazer cotação e contratar o plano de saúde, porem o aplicativo tinha uma baixa qualidade na questão de experiencia do úsuario e foi investido no desenvolvimento de um novo app, sem a contratação de uma terceirizada para isso, visto que a primeira verão do app foi feita por uma terceira.


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:** a diferença é que o struct faz uma cópia de valor, ou seja, quando é atribuido a uma nova variável é feita uma cópia dos dados, e a class funciona como um ponteiro, quando é atribuido a uma nova variável, é passada uma referencia de onde aquele objeto está alocado na memória, assim quando altera em um local, é refletida nas outras partes do código onde tem variáveis que apontem para aquele objeto.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:** a principal diferença é que .net framework é voltado para o desenvolvimento exclusivo para ambiente windows enquanto o .net core é multiplataforma. Por exemplo quando você vai fazer um sistema desktop para windows, é usado o .net framework e quando se vai desenvolver microserviços, por exemplo, se usa .net core


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:** nunca utilizei e grpc, mas rest é baseado em http, se fazendo do uso de seus métodos get, post....


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**  o navegador manipula a url utilizando o history api para realizar a troca da pagina sem recarregar, modificando somento o conteudo dinamicamente. o roteador faz o trabalho de controlar o mapeamento da url e carregar o componente correpnondente. toda a manipulação no navegador é interceptada nesse roteador, com ele manipulando o state e alterando a url sem recarregar a pagina e atualizando o conteudo que reflete o novo estado e exibindo o   compontende correspontente da rota.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:** não atuei ainda como devops


10. Explique sobre um método agile.

**Resposta:** é uma metodologia de desenvolvimento que visa a entrega contínua de valor. quando trabalhei na philips utilizavamos o azure boards para realizarmos o controle das sprints, que eram de 4 semanas.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:** faz parte do serviço de devops, apenas estudei sobre mas nunca atuei na configuração de pipelines.


12. Qual a diferença entre Docker e Containers.

**Resposta:**  conteiner é uma unidade portatil que contem todas as ferramentas necessárias para a utilização dos serviços desejados, por exemplo, pode-se instanciar em um conteiner servidor de banco de dados como o mysql ou o zookeeper com kafka para fazer mensageria.
Docker é uma ferramenta que utiliza a tecnologia de conteiner. outra ferramenta que utiliza de conteiner é kubernetes.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:** não conheço a ferramenta openshift


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**  como vantagem, flexibilidade, onde diversas tecnologias de linguagens diferentes podem se comunicar. padronização da mensageme. como desvantagem, segurança, se mal aplicada, pode expor dados que não deveriam.
Alguns pontos que devem ser levados em consideração é a performance, segurança, disponibilidade


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:** através de autenticação e utilização de níveis de autorização, bem como a utilização de tokens.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:**  serve para realizar a troca de informações entre sistemas de maneira assincrona com eficiência.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**  é um modelo de design utilizado para gerenciar transações distribuidas, consiste em dividir uma grande transação em pequenas sendo executadas de forma assincrona e coordenado por meio de evento.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:** não conheço.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**  Atuei em um projeto onde o objetivo foi na migração de um sistema monolítico para microsserviços.
O sistema era responsável pela emissão das notas fiscais dos clientes da empresa e tinha um volume de mais de 1 milhão de notas a serem emitidas via API. Foram criados 6 microsserviços:
1 – Microsserviços para criar os lotes nos tópicos.
2 – Microsserviços para enviar os lotes das RPS’s para serem emitidas as notas fiscais.
3 – Microsserviços para consultar o processamento dos lotes enviados.
4 – Microsserviços para obter os dados das notas emitidas dos lotes processados com sucesso.
5 – Microsserviços para obter os dados de quais RPS’s não foram processados por algum erro no processamento e qual o motivo.
6 – Microsserviços para disparo de e-mail das notas fiscais emitidas para os clientes.

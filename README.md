# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:** 

1. Base de Código:
O codigo tem que ser rastreavel atraves de versionamento
2. Dependências:
Declarar as dependencias no arquivo de config a depender da liguagem pra facilitar caso algum outro dev pegue o codigo
3. Configurações:
Armazenar as variaveis de ambiente para config do projeto corretamente nao deixa no codigo, complementando, da para apontar as veriaveis para um vault e pegar os valores de lá, dessa forma fica mais segunro ainda
4. Serviços de Apoio:
Conexão com os serviços de apoio seria basicamente outras aplicações com compoem o projeto, bd, email, filas de envio, podemos até assumir que o item 4 se comunica diretamente com o 3 para uma melhor segurança
5. Construir, Lançar, Executar:
Podemos assumir que seria o processo de uma pipeline, builda o projeto, sobe pra branch dev, passa pela QA e após aprovação vai pra prod
6. Processos:
O processo da aplicação tem que rodar no back para não ter a chance por exemplo de pegar alguma informação sensivel 
Obs.: Não conhecia por esse nome "Twelve-Factor App", tive que pesquisar para validar se era realmente oque eu achava que era.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
Depende de projeto para projeto, a experiencia que tive foi em mvc mas hoje participo de um projeto que está sendo desenvolvido em solid

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
O Soa vai ter a camada de conexão esb e vai se comunicar com alguns serviços, seriços esses mais genericos, exemplo: Alterar dados da carga
microserviços no meu entendimento é uma divisão(literalmene) do soa com uma comunicação direta, varios mini serviços com pequenas atividades, alterar data da carga, alterar saida da carga...

Ambos escalaveis mas microserviços bem mais dinamico

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
Gerenciar as conexões, monitorar e fornecer informações sobre as APIs, hoje o unico que tenho conhecimento("de vista") é o apim da azure, mas não obrigatóriamente o permissionamento fica nele, pode estar no projeto em si

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Não conhecia o tipo Struct, mas pesquisando vi que é uma class sem herança e um monte de outras funcionalidade, algo mais simples apenas uma especie de bloco de variaveis

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
.Net é mantido pela microsoft e é fechado com algumas limitações, já o core alem de codigo aberto ele tem varias facilidades, incluindo cloud e performance.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
Rest utilizamos mais utilizado em apis publicas ou de cominucação externa até por ser mais facil sua leitura no json por exemplo, mas o grpc é mais perfomatico e na como a comunicação não é um texto acaba sendo mais leve, porem utilizada mais internamente para comunicação entre aplicações

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
Seria basicamente um blocão de codigo que é iniciado uma vez e quando que clicar em algum tipo de chamada ou redirecionamento é chamado somente o "necessario" para aquilo, meio que um modulo, em vez de por exemplo carregar toda vez as paginas web ele só chama o modulo que já foi carregado.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
Uma mescla de um arquiteto com um dev, e o tipo de atividade que vai contemplar tanto o deploy, ci/cd, monitoramento da aplicação seja ela on-primesse ou nuvem e até quem atua nessa parte ajuda muito na ponte do dev da aplicação com o arquiteto do ambiente

10. Explique sobre um método agile.

**Resposta:**
Acho que o mais comum é o scrum que tem basicamente a funcionalidade de agilizar o processo, organizar e estar mostrando sempre para o cliente oque está ocorrente ali de tempos em tempos.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI seria basicamente a comunicação do  dev com o resto da equipe a partir por exemplo do  repositório, agilizando esse processo todos tem contato com as mudanças, já o CD é mais a parte do deploy, no azure devops temos algumas ferramentas que auxiliam como a pipeline para automatizar varias validações e aproções de holog pra prod por exemplo e uma outra seria o sonar para automatizar o processo de qualidade do codigo.

12. Qual a diferença entre Docker e Containers.

**Resposta:**
Conteiners é como de fosse uma caixa mesmo que você coloca a aplicação e ela roda ali sem necessidade externa nenhuma, o docker é uma caixa maior que tem varios conteiners, de certa forma posso falar que é uma plataforma

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Kb é uma plataforma de gerenciamento/orquestração de containers, faz o deploy, escala, gerencia e monitora containers automaticamente e o  Openshift é um kb "melhorado" na segurança.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
A comunicação sem duvidas, facilita muito a integração entre sistemas que usam tecnologias diferentes, a api seja rest ou soa el tem meio que um denominador em comum(json, xml...) o unico problema é que se feito da forma erra da muita abertura para invasões ou algum outro tipo de maldade. Sem duvidas escolhemos apis que é algo que precisa ser externo ao sistema, em um monolito on-primesse não tem necessidade validação de usuario do AD via api, está on-primesse então eu conecto direto, já um sistema que tem permissionamento e outros sistemas conectam nele ai sim temos a necessidade de uma api para uma comunicação externa

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Fazendo o permissionamento correto, sempre com autenticação e nada de consultas como select * from tabela .... que traz informações  "infinitas", a depender do sistema se for em nuvem em um ambiente totalemte ligado o back end se comunicar via vpn ou um canal direto assim não se tem nenhuma interferencia externa, e inumeras boas praticas.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Principalmente para desempenho, ficar fazendo muita requisição direto não é muito perfomatica, utilizar filas de mensagerias acaba sendo mais eficiente

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
Em vez de um BEGIN TRANSACTION / COMMIT, cada serviço executa sua parte da transação de forma independente, e, se algo der errado, executa ações compensatórias para desfazer as operações anteriores.
Obs.: Nunca usei e nem tinha conhecimento sobre.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
No meu entendimento uma especie de centralização de tudo do sistema com versionamento utilizando o kurbenetes, meio que tornando um ou varios repositorios uma especie de wiki do projeto com todo histórico

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**

Tecnologias: Java Spring, Oracle SQL e HTML(comunicação via thymeleaf)

A necessidade do desenvolvimento surgiu após a constatação de que a equipe de qualidade fazia o seguinte processo para analise da qualidade do atendimento do hospital:

Coletava dados dos funcionarios sobre incidentes/acidentes > Coletava dados sobre atendimentos do pacientes > Registrava em uma planilha > Classificava o inicidente > enviava para o responsavel do setor resolver

Foi montado um sistema para que eles entrassem, realizasse esse cadastro se necessario do incidente e automaticamente o sistema já classificava, enviava para os responsaveis, guardava histórico. Alem do lançamento manual tinha a opção do paciente ou funcionario realizar o lançamento.

Case 2 

Tecnologias: Python, SQLserver e HTML

Motivo: diminuir tempo de espera de motoristas para retirada de carga

Ao liberar uma carga no sistema uma trigger disparava para uma fila onde um robo em python fazia a leitura enviando uma mensagem via whatsapp para o motorista e um email para a transportadora, junto a isso foi implantado QR codes nos impressos de protocolos dos motoristas para consultarem em tempo real o status do agendamento dos mesmos, reduzindo o tempo de espera e atrasos na liberação.

#language: pt-br
Funcionalidade: Login

Cenário: Acesso o site e verifico que estou na loginpage
	Dado que acesso o site
	Então vejo que estou na login page

Cenário: Autentico no sistema com credenciais válidas
	Dado que acesso o site
	Quando informo as seguintes credenciais
		| Username      | Password     |
		| standard_user | secret_sauce |
	E me autentico no sistema
	Entao o usuário aparece logado

Cenário: Tento autenticar no sistema com credenciais bloqueadas
	Dado que acesso o site
	Quando informo as seguintes credenciais
		| Username        | Password     |
		| locked_out_user | secret_sauce |
	E me autentico no sistema
	Entao um erro aparece informando que o usuário está bloqueado
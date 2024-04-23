import subprocess

def test(file_name):
    command = ["pip", "install", "-r", file_name]
    result = subprocess.run(command, capture_output=True, text=True)
    
    if result.returncode != 0:
        print("Error:", result.stderr)
        return None
    
    return "Requirements installed successfully."

def main():
    # requirements.txt ファイルのパスを指定
    requirements_file = "python/requirements.txt"
    
    # test()を呼び出し、結果を取得
    result = test(requirements_file)
    
    # 結果を表示
    if result is not None:
        print(result)
    else:
        print("Failed to install requirements.")

# 直接実行された場合のみmain()を呼び出す
if __name__ == "__main__":
    main()

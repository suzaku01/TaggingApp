import sys
import subprocess

def test(file_name, threshold):
    command = ["python", "python/run.py", "--dir", file_name, "--threshold", str(threshold), "--overwrite"]        
    result = subprocess.run(command, capture_output=True, text=True)
    
    if result.returncode != 0:
        print("Error:", result.stderr)
        return None
    
    output_lines = result.stdout.splitlines()
    tags_str = ""
    for line in output_lines:
        if line.strip():
            tags_str += line.strip() + "\n"

    return tags_str

if __name__ == "__main__":
    if len(sys.argv) != 2:
        print("Usage: python hogehoge2.py <file_name>")
        sys.exit(1)
    
    file_name = sys.argv[1]
    tags_str = test(file_name)
    if tags_str is not None:
        print("tags_str:", tags_str)
    else:
        print("Failed to retrieve tags_str.")
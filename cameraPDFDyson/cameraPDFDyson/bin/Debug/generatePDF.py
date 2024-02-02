# generate_pdf.py
import subprocess

try:
    import fpdf
except ImportError:
    subprocess.run(["pip", "install", "fpdf"])
    import fpdf

from fpdf import FPDF

class PDFGenerator:
    def generate_pdf(self, image_path, output_path):
        pdf = FPDF()
        pdf.add_page()
        pdf.image(image_path, x=10, y=10, w=190)
        pdf.output(output_path)

if __name__ == "__main__":
    # Ejemplo de uso
    generator = PDFGenerator()
    generator.generate_pdf("input_image.png", "output_pdf.pdf")


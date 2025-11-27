/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./**/*.{razor,html,cshtml}",
    "./Pages/**/*.razor",
    "./components/**/*.razor",
    "./Layout/**/*.razor",
    "./wwwroot/index.html",
  ],
  theme: {
    extend: {
      colors: {
        "text-primary": "#3D3D3D",
        "text-highlight": "#1F1F1F",
        surface: "#F8F8F8",
        // Semantic colors for better UX
        primary: {
          50: "#eff6ff",
          100: "#dbeafe",
          500: "#3b82f6",
          600: "#2563eb",
          700: "#1d4ed8",
        },
        error: {
          50: "#fef2f2",
          500: "#ef4444",
          600: "#dc2626",
        },
        success: {
          50: "#f0fdf4",
          500: "#22c55e",
          600: "#16a34a",
        },
      },
      fontFamily: {
        lucida: ['"Lucida Console"', "monospace"],
        "open-sans": ['"Open Sans"', "sans-serif"],
      },
      spacing: {
        18: "4.5rem",
        88: "22rem",
      },
      animation: {
        "spin-slow": "spin 3s linear infinite",
        "fade-in": "fadeIn 0.3s ease-in",
      },
      keyframes: {
        fadeIn: {
          "0%": { opacity: "0" },
          "100%": { opacity: "1" },
        },
      },
    },
  },
  plugins: [],
};

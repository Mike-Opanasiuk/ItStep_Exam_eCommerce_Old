import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import { resolve as resolvePath } from 'path';

// https://vitejs.dev/config/
export default defineConfig({
  resolve: {
    alias: {
      "@base": resolvePath(__dirname, "./src/components/base"),
      "@layout": resolvePath(__dirname, "./src/components/layout"),
    }
  },
  plugins: [react()]
})
